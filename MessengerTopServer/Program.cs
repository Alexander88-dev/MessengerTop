using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MessengerTopServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            Console.WriteLine("Server started on port 5000");
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                _ = HandleClientAsync(client);
            }
        }

        static async Task HandleClientAsync(TcpClient client)
        {
         string loginGlobal = null;
            try
            {
                using (NetworkStream stream = client.GetStream())
                using (StreamReader reader = new StreamReader(stream))
                using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
                {
                    while (true)
                    {
                        string request = await reader.ReadLineAsync();

                        if (request == null)
                        {
                            Console.WriteLine("Клиент отлючился");
                            break;
                        }

                        if (request.StartsWith("LOGIN"))
                        {
                            string[] parts = request.Split('|');
                            string result = await AuthService.LoginAsync(parts[1], parts[2]);
                            loginGlobal = parts[1];
                            await writer.WriteLineAsync(result);
                        }
                        if (request.StartsWith("REGISTER"))
                        {
                            string[] parts = request.Split('|');
                            string res = await AuthService.RegisterAsync(parts[1], parts[2]);
                            await writer.WriteLineAsync(res);
                        }

                        if (request.StartsWith("USERS_LIST"))
                        {
                            string[] parts = request.Split('|');

                            var result = await AuthService.UsersListAsync(loginGlobal);

                            string response = string.Join("|", result);

                            await writer.WriteLineAsync(response);
                        }
                        if (request.StartsWith("CHANGE_NICK"))
                        {
                            string[] parts = request.Split('|');

                            string NewNick = parts[1];

                            string result = await AuthService.ChangeNickAsync(loginGlobal, NewNick);

                            await writer.WriteLineAsync(result);
                        }

                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Клиент отключён");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Server error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

    }
}
