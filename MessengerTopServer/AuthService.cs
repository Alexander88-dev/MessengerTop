using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerTopServer
{
    internal class AuthService
    {
        public static async Task<string> LoginAsync(string username, string password)
        {
            using (var db = new ServerTopEntities1())
            {
                var user = db.User.FirstOrDefault(u => u.Login == username);

                if (user == null)
                {
                    return "NOT_FOUND";
                }

                bool isValid = BCrypt.Net.BCrypt.Verify(password, user.Password);

                if (!isValid)
                {
                    return "WRONG_PASSWORD";
                }

                return "SUCCESS";
            }
        }
        public static async Task<string> RegisterAsync(string username, string password)
        {
            using (var db = new ServerTopEntities1())
            {
                var user_exist = await db.User.AnyAsync(u => u.Login == username);

                if (user_exist)
                {
                    return "USER_EXISTS";
                }

                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                User user = new User()
                {
                    Login = username,
                    Password = passwordHash,
                    Lvl = 0
                };
                db.User.Add(user);
                await db.SaveChangesAsync();

                return "SUCCESS";
            }
        }
        public static async Task<string> ChangeNickAsync(string login, string NewNick)
        {
            using (var db = new ServerTopEntities1())
            {
                var user = await db.User.FirstOrDefaultAsync(u => u.Login == login);

                if (user == null)
                {
                    return "NOT_FOUND";
                }

                bool nickExists = await db.User.AnyAsync(u => u.Nick == NewNick && u.Login != login);
                if (nickExists)
                {
                    return "NICK_EXISTS";
                }
                user.Nick = NewNick;
                await db.SaveChangesAsync();

                return "SUCCESS";
            }
        }
    }
}