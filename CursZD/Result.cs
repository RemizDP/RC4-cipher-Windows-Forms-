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

namespace CursZD
{
    public partial class Result : Form
    {
        public MainForm mainWnd = null;
        public byte[] resultData;
        public Result()
        {
            MdiParent = mainWnd;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(mainWnd.filePath);
            mainWnd.filePath = "";
            Close();
            mainWnd.выбратьФайлToolStripMenuItem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainWnd.filePath = "";
            Close();
            mainWnd.выбратьФайлToolStripMenuItem.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileLabel.Text = saveFile.FileName;
                
                using (var data = new BinaryWriter(File.Open(saveFile.FileName, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    data.Write(resultData);
                }
            }
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileLabel.Text == "")
                MessageBox.Show("Файл с результатом не был сохранен", "Предупреждение");
        }
    }
}
