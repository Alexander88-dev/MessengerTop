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
    }
}
