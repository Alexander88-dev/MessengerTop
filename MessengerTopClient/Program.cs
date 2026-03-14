using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerTopClient
{
    internal static class Program
    {
        public static ServerConnection connection;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            connection = new ServerConnection();
            await connection.ConnectAsync();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
