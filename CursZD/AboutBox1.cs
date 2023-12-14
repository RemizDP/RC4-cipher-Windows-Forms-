using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursZD
{
    partial class AboutBox1 : Form
    {
        public MainForm mainWnd = null;
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = "Курсовая работа, вариант 20";
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = "Ремизов Д.П. А-05-20";
            this.labelCompanyName.Text = "НИУ МЭИ";
            this.textBoxDescription.Text =  "20.\tПрограммная реализация криптоалгоритма RC4.\r\n" +
                                            "Указания по темам 9-25: \r\n" +
                                            "•\tвозможность шифрования/расшифрования как выбираемых файлов любого типа, так и вводимых текстовых сообщений на ключе," +
                                            " выводимом из парольной фразы с регулируемой пользователем минимальной длиной и сложностью; \r\n" +
                                            "•\tдля блочных шифров возможность выбора пользователем режима шифрования/расшифрования;\r\n" +
                                            "•\tвозможность при расшифровании проверять правильность введенной парольной фразы" +
                                            " (например, путем добавления к данным перед их шифрованием сигнатуры – специальной " +
                                            "строки символов – с проверкой ее наличия в расшифрованных данных и удалением из них в случае успешной проверки);\r\n" +
                                            "•\tвозможность удаления шифруемого (расшифровываемого) файла после выполнения криптографической операции;\r\n" +
                                            "•\tвозможность сохранения зашифрованного введенного пользователем текстового сообщения в файле с выбираемым именем.\r\n \r\n" +
                                            "\tЗамечанния.\r\n" +
                                            "Ставить галочку в поле выбора проверки шифрации/дешифрации имеет смысл только если шифрация тоже была произведена с проверкой. \r\n" +
                                            "Проверка представляет из себя добавление перед шифрацией в начало массива байт некоторой контрольной строки, наличие которой проверяется, если дешифрация производится с проверкой." +
                                            "Если строка не найдена, выдается сообщение об ошибке (предполагается что при вызове функций шифрации и дешифрации были использованы разные аргументы),  в противном случае контрольная строка удаляется и возвращается \"чистый\" массив данных \r\n" +
                                            "При шифрации текстовых сообщений, сохранении их в файл и последующей дешифрации их через режим файла производится корректно, но при вводе зашифрованного сообщения в поле ввода текстового сообщения при дешифрации" +
                                            " происходит конфликт кодировок, который мне не удалось решить. Соответственно, дешифрация производится некорректно.";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWnd.оПрограммеToolStripMenuItem.Enabled = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
