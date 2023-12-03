using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursZD
{
    public partial class MainForm : Form
    {
        public string filePath;
        public static string LatinLow = "abcdefghijklmnopqrstuvwxyz";
        public static string LatinHigh = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Numbers = "0123456789";
        public static string Special = ".,?!@#$%&";

        public bool PassCheck(string password, string req)
        {
            bool res = false; 
            for (int i = 0; i< password.Length && !res;i++)
            {
                if (req.Contains(password[i]))
                    res = true;
            }
            return res;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void выбратьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            выбратьФайлToolStripMenuItem.Enabled = false;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                SetupDialog  setup = new SetupDialog();
                setup.mainWnd = this;
                setup.MdiParent = this;
                setup.Show();
            }
            else
                выбратьФайлToolStripMenuItem.Enabled = true;
        }

        private void завершитьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.mainWnd = this;
            about.MdiParent = this;
            about.Show();
            оПрограммеToolStripMenuItem.Enabled = false;
        }

        private void текстовыеСообщенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            текстовыеСообщенияToolStripMenuItem.Enabled = false;
            MessageInput setup = new MessageInput();
            setup.mainWnd = this;
            setup.MdiParent = this;
            setup.Show();
        }
    }
}
