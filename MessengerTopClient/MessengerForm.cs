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
        }
        private void MessengerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.connection.Close();
        }
        
        private async void AddingToTheListAsync()
        {
            var response = await Program.connection.SendAsync($"USERS_LIST");

            foreach (string item in response.Split('|')) 
            {
                listBox.Items.Add(item);
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettForm settForm = new SettForm(_fileFormColor);
            settForm.FormClosing += (s, args) =>
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
                this.Show();
            };
            settForm.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = listBox.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MessengerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
