using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MessengerTopClient
{
    internal class ServerConnection
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;

        public async Task ConnectAsync()
        {
            _client = new TcpClient();
            await _client.ConnectAsync("127.0.0.1", 5000);

            var stream = _client.GetStream();
            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream)
            { AutoFlush = true };
        }
        public async Task <string> SendAsync(string message)
        {
            await _writer.WriteLineAsync(message);
            return await _reader.ReadLineAsync();
        }
        public async Task<string> ChangeNameAsync(int userId, string newName)
        {
            string request = $"CHANGENAME|{userId}|{newName}";
            return await SendAsync(request);
        }
    }
}
