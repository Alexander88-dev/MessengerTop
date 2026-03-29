using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MessengerTopClient
{
    public partial class MessengerForm : Form
    {
        private string _fileFormColor;


        public MessengerForm(string fileFormColor)
        {
            InitializeComponent();
            AddingToTheListAsync();
            _fileFormColor = fileFormColor;
            ColorForm();

            timer1.Interval = 3000;
            timer1.Start();
        }
        private void MessengerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.connection.Close();
        }

        private async void AddingToTheListAsync()
        {
            try
            {
                var response = await Program.connection.SendAsync($"USERS_LIST");
                if (!string.IsNullOrEmpty(response))
                {
                    listBox.Items.Clear();
                    foreach (string item in response.Split('|'))
                    {
                        if (!string.IsNullOrWhiteSpace(item))
                            listBox.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления списка пользователей: " + ex.Message);
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettForm settForm = new SettForm(_fileFormColor);
            settForm.FormClosing += (s, args) =>
            {
                ColorForm();
                this.Show();
            };
            settForm.Show();
            this.Hide();
        }
        private void ColorForm()
        {
            try
            {
                string[] FFColor = File.ReadAllLines(_fileFormColor);
                FFColor = FFColor[1].Split('|');
                this.BackColor = Color.FromArgb(Convert.ToInt32(FFColor[0]), Convert.ToInt32(FFColor[1]), Convert.ToInt32(FFColor[2]));
            }
            catch
            {
                MessageBox.Show("Файл FormColor.txt не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                richTextBox.Clear();
                label.Text = listBox.SelectedItem.ToString();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            string selectedUser = listBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedUser))
            {

                string response = await Program.connection.SendAsync($"GET_MSG|{selectedUser}");

                if (!string.IsNullOrEmpty(response) && response != "EMPTY" && response != "NO_NEW")
                {

                    string[] messages = response.Split('/');
                    foreach (var m in messages)
                    {
                        richTextBox.AppendText($"{selectedUser}: {m}{Environment.NewLine}");
                    }
                }
            }
        }

        private void MessengerForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string selectedUser = listBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Выберите пользователя!");
                return;
            }

            string messageText = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(messageText)) return;

            try
            {
                Console.WriteLine($"Отправка сообщения для {selectedUser}...");


                string response = await Program.connection.SendAsync($"SEND|{selectedUser}|{messageText}");

                Console.WriteLine($"Ответ сервера: {response}");

                if (response == "OK")
                {
                    richTextBox.AppendText($"Вы: {messageText}{Environment.NewLine}");
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Сервер не подтвердил получение: " + response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
                MessageBox.Show("Произошла критическая ошибка: " + ex.Message);
            }
        }
    }
}
    

