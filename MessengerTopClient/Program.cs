using System;
using System.Collections.Generic;
using System.IO;
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
            string fileFormColor = "FormColor.txt";
            FileColorForm(fileFormColor);
            
            connection = new ServerConnection();
            await connection.ConnectAsync();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(fileFormColor));
        }

        static async void FileColorForm(string fileFormColor) 
        {
            if (!File.Exists(fileFormColor)) 
            {
                File.WriteAllText(fileFormColor, "Базовый\n");
                File.AppendAllText(fileFormColor, "135|206|250");
            }
        }
    }
}
