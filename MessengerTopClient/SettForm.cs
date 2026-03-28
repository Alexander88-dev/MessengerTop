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
    public partial class SettForm : Form
    {
        private string _fileFormColor;
        private string[] _FFColor;

        public SettForm(string fileFormColor)
        {
            InitializeComponent();

            ColForm.Items.Add("Базовый");
            ColForm.Items.Add("Светлый");
            ColForm.Items.Add("Темный");

            _fileFormColor = fileFormColor;
            
            try
            {
                _FFColor = File.ReadAllLines(fileFormColor);
                int index = 0;
                ColForm.SelectedItem = _FFColor[0];
                FormColor();
            }
            catch (Exception ex) 
            {// Можно добавить вопрос на перезагрузку программы
                MessageBox.Show("Файл FormColor.txt не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void FormColor()
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

        private void GroupCreatebtn_Click(object sender, EventArgs e)
        {
            Form1 createGroupForm = new Form1(_fileFormColor);
            createGroupForm.FormClosing += (s, args) =>
            {
                this.Show();
            };
            createGroupForm.Show();
            this.Hide();
        }

        private void btnNickname_Click(object sender, EventArgs e)
        {
            ChangeNameForm changeNameForm = new ChangeNameForm(_fileFormColor);
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

        private void ColForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColForm.SelectedIndex)
            {
                case 0:
                    File.WriteAllText(_fileFormColor, "Базовый\n");
                    File.AppendAllText(_fileFormColor, "135|206|250");
                    break;
                case 1:
                    File.WriteAllText(_fileFormColor, "Светлый\n");
                    File.AppendAllText(_fileFormColor, "255|250|250");
                    break;
                case 2:
                    File.WriteAllText(_fileFormColor, "Темный\n");
                    File.AppendAllText(_fileFormColor, "59|59|59");
                    break;
            }
            FormColor();
        }

        private void SettForm_Load(object sender, EventArgs e)
        {
        }
    }
}
