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
        private string _fileFormColor;
        public LoginForm(string fileFormColor)
        {
            InitializeComponent();
            _fileFormColor = fileFormColor;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.connection.Close();
        }

        private async void btnLog_ClickAsync(object sender, EventArgs e)
        {
            string login = txtLog.Text;
            string password = txtPass.Text;

            string response = await Program.connection.SendAsync($"LOGIN|{login}|{password}");

             switch (response)
             {
                case "LOGIN_PASSWORD_ERROR":
                    lblError.Text = "Неверный логин или пароль!";
                    break;
                case "ERROR":
                    lblError.Text = "Неверный логин или пароль!";
                    break;
                case "SUCCESS":
                    MessengerForm mainForm = new MessengerForm(_fileFormColor);

                    mainForm.FormClosing += (s, args) =>
                    {
                        this.Show();
                        txtPass.Clear();
                        lblError.Text = "";
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
                lblError.Text = "";
            };
            registrationForm.Show();
            this.Hide();
        }
    }
}
