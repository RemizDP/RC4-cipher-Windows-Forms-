using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursZD
{
    public partial class SetupDialog : Form
    {
        public MainForm mainWnd;
        public int minLength = 0;
        public int keyLength = 0;
        public int blockLength = 0;

        public SetupDialog()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(MinPasswordPhrazeLengthTextBox.Text, out int l))
            {
                minLength = l;
            }
            else
            {
                MessageBox.Show("Строка в поле минимальной длины не является целым числом!", "Ошибка ввода");
                minLength = 0;
            }
            if (Int32.TryParse(KeyLengthTextBox.Text, out int k))
            {
                if(k>=8 && k<=16)
                    keyLength = k;
                else
                    keyLength = 0;

            }
            else
            {
                MessageBox.Show("Строка в поле длины ключа не является целым числом!", "Ошибка ввода");
                keyLength = 0;
            }
            if(minLength>0 && keyLength>0 )
            {
                Passphrase passWnd = new Passphrase();
                passWnd.setupWnd = this;
                passWnd.MdiParent = mainWnd;
                this.Hide();
                passWnd.key = new byte[keyLength]; 
                passWnd.Show();
            }
            else
            {
                MessageBox.Show("Одно или несколько значений не являются положительными числами или не соответствуют допустимым значениям", "Ошибка ввода");
            }
        }


        private void SetupDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWnd.выбратьФайлToolStripMenuItem.Enabled = true;
        }
    }
}
