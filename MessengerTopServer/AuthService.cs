using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerTopServer
{
    internal class AuthService
    {
        public static async Task<string> RegisterAsync(string username, string password)
        {
            using (var db = new ServerTopEntities())
            {
                var user_exist = await db.User.AnyAsync(u => u.Login == username);
                if (user_exist) return "USER_EXISTS";

                User user = new User()
                {
                    Login = username,
                    Password = BCrypt.Net.BCrypt.HashPassword(password),
                    Nick = username,
                    Lvl = 0
                };
                db.User.Add(user);
                await db.SaveChangesAsync();
                return "SUCCESS";
            }
        }

        public static async Task<string> LoginAsync(string login, string password)
        {
            using (var db = new ServerTopEntities())
            {
                var user = await db.User.FirstOrDefaultAsync(u => u.Login == login);
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return "SUCCESS";
                }
                return "ERROR";
            }
        }


        public static async Task<List<string>> UsersListAsync(string currentLogin)
        {
            using (var db = new ServerTopEntities())
            {
                return await db.User
                    .Where(u => u.Login != currentLogin)
                    .Select(u => u.Login)
                    .ToListAsync();
            }
        }


        public static async Task<bool> SaveMessageAsync(string fromUser, string toUser, string text)
        {
            try
            {
                using (var db = new ServerTopEntities())
                {

                    var sender = await db.User.FirstOrDefaultAsync(u => u.Login == fromUser);

                    if (sender == null) return false;

                    var newMessage = new Message()
                    {
                        Chat_Id = 0,
                        User_From_Id = sender.Id,
                        Date_time_mess = DateTime.Now,


                        Message1 = text
                    };

                    db.Message.Add(newMessage);
                    await db.SaveChangesAsync();

                    Console.WriteLine($"[DB]: Сообщение от {fromUser} сохранено в базу.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[DB ERROR]: {ex.Message}");

                // ВОТ ЭТА СТРОКА ПОКАЖЕТ НАСТОЯЩУЮ ОШИБКУ:
                if (ex.InnerException != null)
                    Console.WriteLine($"[REAl ERROR]: {ex.InnerException.InnerException?.Message ?? ex.InnerException.Message}");

                Console.ResetColor();
                return false;
            }
        }
    }
}