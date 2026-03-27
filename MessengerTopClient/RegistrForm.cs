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

        private bool ValidateFrom()
        {
            bool b = true;
            lblPassEr.Text = "";
            lblLogEr.Text = "";
            if (string.IsNullOrEmpty(txtLog.Text))
            {
                lblLogEr.Text = "Введите логин";
                b = false;
            }
            if (txtPass.Text.Length < 6)
            {
                lblPassEr.Text = "Пароль минимум 6 символов";
                b = false;
            }
            else if (txtPass.Text.Length != txtConfirmPass.Text.Length)
            {
                lblPassEr.Text = "Пароли не совпадают";
                b = false;
            }
            return b;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            string login = txtLog.Text;
            string password = txtPass.Text;
            if (ValidateFrom())
            {
                string responce = await Program.connection.SendAsync($"REGISTER|{login}|{password}");
                
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
