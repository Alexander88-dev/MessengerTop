using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MessengerTopServer
{
    internal class AuthService
    {
        public static async Task<string> LoginAsync(string username, string password)
        {
            using (var db = new ServerTopEntities2())
            {
                var user = await db.User.FirstOrDefaultAsync(u => u.Login == username);

                if (user == null)
                {
                    return "LOGIN_PASSWORD_ERROR";
                }
                
                bool isValid = BCrypt.Net.BCrypt.Verify(password, user.Password);

                if (!isValid)
                {
                    return "LOGIN_PASSWORD_ERROR";
                }

                return "SUCCESS";
            }
        }
        public static async Task<string> RegisterAsync(string username, string password)
        {
            using (var db = new ServerTopEntities2())
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
                    Nick = "",
                    Lvl = 0
                };
                db.User.Add(user);
                await db.SaveChangesAsync();

                return "SUCCESS";
            }
        }

        public static async Task<List<string>> UsersListAsync(string login)
        {
            using (var db = new ServerTopEntities2())
            {
                List<string> list = new List<string>();
                foreach(var item in db.User) 
                {
                    if(login != item.Login) 
                    {
                        if (item.Nick != "")// Плохо добавлен ник в БД, но менять не будет
                        {
                            list.Add(item.Nick.ToString());
                            continue;
                        }
                        list.Add(item.Login.ToString());
                    }
                }
                return list;
            }
        }

        public static async Task<string> ChangeNickAsync(string login, string NewNick)
        {
            using (var db = new ServerTopEntities2())
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
    }
}