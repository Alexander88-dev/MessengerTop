using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MessengerTopClient
{
    public partial class Form1 : Form
    {
        private string[] _FFColor;
        public Form1(string fileFormColor)
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

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
