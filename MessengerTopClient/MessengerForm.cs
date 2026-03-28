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
    public partial class MessengerForm : Form
    {

        
        public MessengerForm()
        {
            InitializeComponent();
            AddingToTheListAsync();
        }
        private void MessengerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.connection.Close();
        }
        
        private async void AddingToTheListAsync()
        {
            //List<string> response = new List<string>();
            //response.CopyTo(await Program.connection.SendAsync($"USERS_LIST"));
            var response = await Program.connection.SendAsync($"USERS_LIST");


            foreach (string item in response.Split('|')) 
            {
                listBox.Items.Add(item);
            }
        
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettForm settForm = new SettForm();
            settForm.FormClosing += (s, args) =>
            {
                this.Show();
            };
            settForm.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = listBox.Text;
        }
    }
}
