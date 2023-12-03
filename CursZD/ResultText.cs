using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursZD
{
    public partial class ResultText : Form
    {
        public MainForm mainWnd = null;
        public byte[] resultData;
        public ResultText()
        {
            InitializeComponent();

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
                Close();

                mainWnd.текстовыеСообщенияToolStripMenuItem.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            mainWnd.текстовыеСообщенияToolStripMenuItem.Enabled = true;

        }

        private void ResultText_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FileLabel.Text == "")

                MessageBox.Show("Файл с результатом не был сохранен", "Предупреждение");
        }

        private void ResultText_Load(object sender, EventArgs e)
        {

            ResultTextBox.Text = Encoding.UTF8.GetString(resultData);
        }
    }
}
