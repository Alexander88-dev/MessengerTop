using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace MessengerTopClient
{
    internal class ServerConnection
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;
        // Этот "светофор" не даст двум запросам выполняться одновременно
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public async Task ConnectAsync()
        {
            _client = new TcpClient();
            await _client.ConnectAsync("127.0.0.1", 5000);

            var stream = _client.GetStream();
            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream) { AutoFlush = true };
        }

        public async Task<string> SendAsync(string message)
        {
            // Ждем своей очереди, если поток занят другим запросом (например, таймером)
            await _semaphore.WaitAsync();
            try
            {
                await _writer.WriteLineAsync(message);
                return await _reader.ReadLineAsync();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
            finally
            {
                // Освобождаем "путь" для следующего запроса
                _semaphore.Release();
            }
        }

        public void Close()
        {
            _reader?.Close();
            _writer?.Close();
            _client?.Close();
        }

        public async Task<string> ChangeNameAsync(int userId, string newName)
        {
            string request = $"CHANGENAME|{userId}|{newName}";
            return await SendAsync(request);
        }
    }
}
