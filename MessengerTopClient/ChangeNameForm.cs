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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MessengerTopClient
{
    public partial class ChangeNameForm : Form
    {
        private string[] _FFColor;
        public ChangeNameForm(string fileFormColor)
        {
            InitializeComponent();

            string[] FFColor = File.ReadAllLines(fileFormColor);
            FFColor = FFColor[1].Split('|');
            try
            {
                this.BackColor = Color.FromArgb(Convert.ToInt32(FFColor[0]), Convert.ToInt32(FFColor[1]), Convert.ToInt32(FFColor[2]));
            }
            catch
            {
                MessageBox.Show("Файл FormColor.txt не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            NickNewAsync();
        }
        private async void NickNewAsync()
        {
            if (txtBoxChange.Text != "")
            {
                try
                {
                    var response = await Program.connection.SendAsync($"CHANGE_NICK|{txtBoxChange.Text}");
                }
                catch
                {
                    lblErr.Text = "Ошибка!";
                    return;
                }
            }
            else 
            {
               lblErr.Text = "Поля ввода пустое";
               return;
            }

            this.Close();
        }
    }
}