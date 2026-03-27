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
    public partial class SettForm : Form
    {
        public SettForm()
        {
            InitializeComponent();
        }

        private void GroupCreatebtn_Click(object sender, EventArgs e)
        {
            Form1 createGroupForm = new Form1();
            createGroupForm.FormClosing += (s, args) =>
            {
                this.Show();
            };
            createGroupForm.Show();
            this.Hide();
        }

        private void btnNickname_Click(object sender, EventArgs e)
        {
            ChangeNameForm changeNameForm = new ChangeNameForm();
            changeNameForm.FormClosing += (s, args) =>
            {
                this.Show();
            };
            changeNameForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
