using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerTopClient
{
    public partial class LoginForm: System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.connection.Close();
        }

        private async void btnLog_ClickAsync(object sender, EventArgs e)
        {
            string login = txtLog.Text;
            string password = txtPass.Text;

            string response = (Program.connection.SendAsync($"LOGIN|{login}|{password}")).ToString();

             switch (response)
            {
                case "NOT_FOUND":
                    MessageBox.Show("Не найден пользователь с таким логином");
                    break;
                case "WRONG_PASSWORD":
                    MessageBox.Show("Найден пользователь, но не верный пароль");
                    break;
                case "SUCCESS":
                    MessengerForm mainForm = new MessengerForm();

                    mainForm.FormClosing += (s, args) =>
                    {
                        this.Show();
                        txtPass.Clear();
                    };

                    mainForm.Show();
                    this.Hide();

                    break;
            }
        }
        private void linkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrForm registrationForm = new RegistrForm();
            registrationForm.FormClosing += (s, args) =>
            {
                this.Show();
                txtLog.Clear();
                txtPass.Clear();
            };
            registrationForm.Show();
            this.Hide();
        }
    }
}
