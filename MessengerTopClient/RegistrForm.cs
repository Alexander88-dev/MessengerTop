using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerTopClient
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message);
            return false;
        }


        private bool ValidateFrom()
        {
            if (string.IsNullOrEmpty(txtLog.Text))
            {
                return ShowError("Введите логин");
            }
            if (txtPass.Text.Length < 6)
            {
                return ShowError("Пароль минимум");
            }
            if (txtPass.Text.Length != txtConfirmPass.Text.Length)
            {
                return ShowError("Пароли не совпадают");
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            string login = txtLog.Text;
            string password = txtPass.Text;
            string email = txtConfirmPass.Text;
            if (ValidateFrom())
            {
                string responce = await Program.connection.SendAsync($"REGISTER|{login}|{password}|{email}");
                switch (responce)
                {
                    case "SUCCESS":
                        this.Close();
                        break;
                    case "USER_EXISTS":
                        MessageBox.Show("Пользовать уже существует");
                        break;
                    default:
                        MessageBox.Show("Ошибка регистрации");
                        break;
                }
            }
        }
    }
}
