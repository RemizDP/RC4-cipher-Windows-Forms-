using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursZD
{
    public partial class Passphrase : Form
    {
        public SetupDialog setupWnd = null;
        public MessageInput inputWnd = null;

        public byte[] data;
        public byte[] key;

        
        public Passphrase()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            bool reqs;
            bool check1;
            bool check2;
            bool check3;
            bool check4;
            bool checkResult = false;
            bool checkLength = false;
            bool cipher = true;
            bool checkCompare = false;
            int cipherMode = 1;

            byte[] filedata;
            byte[] messagedata;

            if (setupWnd != null)
            {
                if (setupWnd.checkBox1.Checked)
                {
                    checkResult = true;
                }
                else {
                    checkResult = false;
                }
                if (PasswordBox1.Text == PasswordBox2.Text)
                {
                    checkCompare = true;
                }
                if (PasswordBox1.Text.Length >= setupWnd.minLength)
                {
                    checkLength = true;
                }
                if (setupWnd.DecipherButton.Checked)
                {
                    cipher = false;
                }
                else if (setupWnd.CipherButton.Checked)
                {
                    cipher = true;
                }

                if (setupWnd.LatinLowCheckBox.Checked) 
                {
                    check1 = setupWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.LatinLow);
                }
                else { check1 = true; }

                if (setupWnd.LatinHighCheckBox.Checked)
                {
                    check2 = setupWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.LatinHigh);
                }
                else { check2 = true; }

                if (setupWnd.NumsCheckBox.Checked)
                {
                    check3 = setupWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.Numbers);
                }
                else { check3 = true; }

                if (setupWnd.SpecialCheckBox.Checked)
                {
                    check4 = setupWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.Special);
                }
                else { check4 = true; }


                reqs = check1 && check2 && check3 && check4 && checkLength;
                if (!reqs)
                {
                    MessageBox.Show("Пароль не соответствует заданным требованиям!", "Слишком простой пароль!");
                }
                else if (!checkCompare)
                        MessageBox.Show("Пароли не совпадают!", "Неверные данные!");
                else if(reqs && checkCompare && checkLength)
                {
                    using (var users = new BinaryReader(File.Open(setupWnd.mainWnd.filePath, FileMode.OpenOrCreate), Encoding.UTF8))
                    {
                        var size = new FileInfo(setupWnd.mainWnd.filePath).Length;
                        byte[] readToEnd = new byte[(int)size];
                        readToEnd = users.ReadBytes((int)size);
                        data = readToEnd;
                    }
                    System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                    byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(PasswordBox1.Text));
                    Buffer.BlockCopy(hash, 0, key, 0, key.Length);

                    byte [] result = RC4.Apply(data, key, cipher, ref checkResult);
                    if (setupWnd.checkBox1.Checked)
                    {
                        if (!checkResult)
                        {
                            MessageBox.Show("При дешифровании была использована другая длина ключа или парольная фраза", "!!!");
                        }
                        else
                        {
                            Result res = new Result();
                            res.MdiParent = setupWnd.mainWnd;
                            res.Show();
                            res.mainWnd = setupWnd.mainWnd;
                            res.resultData = result;
                            filedata = result;
                            setupWnd.Close();
                            this.Close();
                        }
                    }
                    else
                    {
                        Result res = new Result();
                        res.MdiParent = setupWnd.mainWnd;
                        res.Show();
                        res.mainWnd = setupWnd.mainWnd;
                        res.resultData = result;
                        filedata = result;
                        setupWnd.Close();
                        this.Close();
                    }
                }
            }
            if (inputWnd != null)
            {
                if (inputWnd.checkBox1.Checked)
                {
                    checkResult = true;
                }
                else
                {
                    checkResult = false;
                }
                if (PasswordBox1.Text == PasswordBox2.Text)
                {
                    checkCompare = true;
                }
                if (PasswordBox1.Text.Length >= inputWnd.minLength)
                {
                    checkLength = true;
                }
                if (inputWnd.DecipherButton.Checked)
                {
                    cipher = false;
                }
                else if (inputWnd.CipherButton.Checked)
                {
                    cipher = true;
                }

                if (inputWnd.LatinLowCheckBox.Checked)
                {
                    check1 = inputWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.LatinLow);
                }
                else
                {
                    check1 = true;
                }
                if (inputWnd.LatinHighCheckBox.Checked)
                {
                    check2 = inputWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.LatinHigh);
                }
                else
                {
                    check2 = true;
                }
                if (inputWnd.NumsCheckBox.Checked)
                {
                    check3 = inputWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.Numbers);
                }
                else
                {
                    check3 = true;
                }
                if (inputWnd.SpecialCheckBox.Checked)
                {
                    check4 = inputWnd.mainWnd.PassCheck(PasswordBox1.Text, MainForm.Special);
                }
                else
                {
                    check4 = true;
                }


                reqs = check1 && check2 && check3 && check4 && checkLength;
                if (!reqs)
                {
                    MessageBox.Show("Пароль не соответствует заданным требованиям!", "Слишком простой пароль!");
                }
                else if (!checkCompare)
                    MessageBox.Show("Пароли не совпадают!", "Неверные данные!");
                else if (reqs && checkCompare && checkLength)
                {
                        data = Encoding.UTF8.GetBytes(inputWnd.MessageTextBox.Text);
                    
                    System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                    byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(PasswordBox1.Text));
                    Buffer.BlockCopy(hash, 0, key, 0, key.Length);
                    byte[] result = RC4.Apply(data, key, cipher, ref checkResult);

                    if (inputWnd.checkBox1.Checked)
                    {
                        if (!checkResult)
                        {
                            MessageBox.Show("При дешифровании была использована другая длина ключа или парольная фраза", "!!!");
                        }
                        else
                        {
                            ResultText res = new ResultText();
                            res.resultData = result;
                            messagedata = result;
                            res.MdiParent = inputWnd.mainWnd;
                            res.Show();
                            res.mainWnd = inputWnd.mainWnd;
                            inputWnd.Close();
                            this.Close();
                        }
                    }
                    else
                    {
                        ResultText res = new ResultText();
                        res.resultData = result;
                        messagedata = result;
                        res.MdiParent = inputWnd.mainWnd;
                        res.Show();
                        res.mainWnd = inputWnd.mainWnd;
                        inputWnd.Close();
                        this.Close();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            if (setupWnd != null)
                setupWnd.Show();
            if(inputWnd != null)
                inputWnd.Show();
        }
    }
}
