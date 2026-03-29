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
    public class MessageEntry
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Text { get; set; }
    }

    internal class Program
    {
        private static List<MessageEntry> MessageStorage = new List<MessageEntry>();

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
                        if (request == null) break;

                        Console.WriteLine($"Лог: {request}");
                        string[] parts = request.Split('|');
                        string command = parts[0];

                        if (command == "LOGIN")
                        {
                            string res = await AuthService.LoginAsync(parts[1], parts[2]);
                            if (res == "SUCCESS") loginGlobal = parts[1];
                            await writer.WriteLineAsync(res);
                        }
                        else if (command == "REGISTER")
                        {
                            string res = await AuthService.RegisterAsync(parts[1], parts[2]);
                            await writer.WriteLineAsync(res);
                        }
                        else if (command == "USERS_LIST")
                        {
                            var users = await AuthService.UsersListAsync(loginGlobal);
                            await writer.WriteLineAsync(string.Join("|", users));
                        }
                        else if (request.StartsWith("CHANGE_NICK"))
                        {
                          //  string[] parts = request.Split('|');

                            string NewNick = parts[1];

                            string result = await AuthService.ChangeNickAsync(loginGlobal, NewNick);

                            await writer.WriteLineAsync(result);
                        }
                        else if (command == "SEND")
                        {
                            string to = parts[1];
                            string text = parts[2];


                            await AuthService.SaveMessageAsync(loginGlobal, to, text);

                            MessageStorage.Add(new MessageEntry { From = loginGlobal, To = to, Text = text });
                            await writer.WriteLineAsync("OK");
                        }
                        else if (command == "GET_MSG")
                        {
                            string from = parts[1];
                            var msgs = MessageStorage.Where(m => m.To == loginGlobal && m.From == from).ToList();

                            if (msgs.Count > 0)
                            {
                                await writer.WriteLineAsync(string.Join("#", msgs.Select(m => m.Text)));
                                MessageStorage.RemoveAll(m => m.To == loginGlobal && m.From == from);
                            }
                            else await writer.WriteLineAsync("EMPTY");
                        }
                    }
                }
            }
            catch { Console.WriteLine("Клиент отключился."); }
            finally { client.Close(); }
        }
    }
}
/*

 


  public static async Task<string> ChangeNickAsync(string login, string NewNick)
        {
            using (var db = new ServerTopEntities())
            {
               
                bool nickExists = await db.User.AnyAsync(u => u.Nick == NewNick && u.Login == login);
                if (nickExists)
                {
                    return "NICK_EXISTS";
                }

                var user = await db.User.FirstOrDefaultAsync(u => u.Login == login);
                user.Nick = NewNick;

                await db.SaveChangesAsync();

                return "SUCCESS";
            }
        }
 */