using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CursZD
{
    public static class RC4
    {
        public static byte[] Apply(byte[] data, byte[] key)
        {
            //1) Инициализация S-блока: заполняем массив значениями от 0 до 255
            int[] S = new int[256];
            for (int k = 0; k < 256; k++)
                S[k] = k;

            int j = 0;
            for (int k = 0; k < 256; k++)
            {
                j = (j + S[k] + key[k % key.Length]) % 256;
                int temp = S[k];
                S[k] = S[j];
                S[j] = temp;
            }
            //2) Генерация псевдослучайного слова К
            int i = 0;
            j = 0;

            byte[] result = new byte[data.Length];
            for (int iteration = 0; iteration < data.Length; iteration++)
            {
                i = (i + 1) % 256;
                j = (j + S[i]) % 256;
                int temp = S[i];
                S[i] = S[j];
                S[j] = temp;
                int K = S[(S[i] + S[j]) % 256];
                result[iteration] = Convert.ToByte(data[iteration] ^ K);
            }
            return result;
        }
        public static byte[] Apply(byte[] Inputdata, byte[] key, bool cipher, ref bool check)
        {
            byte[] data = new byte[Inputdata.Length];
            byte[] check1 = Encoding.UTF8.GetBytes("check123!@#");

            if (cipher && check)
            {
                data = new byte[Inputdata.Length + check1.Length];
                Buffer.BlockCopy(check1, 0, data, 0, check1.Length);
                Buffer.BlockCopy(Inputdata, 0, data, check1.Length, Inputdata.Length);
            }
            else
            {

                Buffer.BlockCopy(Inputdata, 0, data, 0, Inputdata.Length);
            }

            byte[] result = Apply(data, key);
            if (!cipher)
            {
                if (check)
                {
                    byte[] check2 = new byte[check1.Length];
                    Buffer.BlockCopy(result, 0, check2, 0, check1.Length);
                    Console.WriteLine(Encoding.UTF8.GetString(check1) + "  " + Encoding.UTF8.GetString(check2));
                    for (int j = 0; j < check1.Length && check; j++)
                        if (check2[j] != check1[j])
                        {
                            check = false;
                        }
                }

                int i = result.Length;
                
                if (check)
                {
                    i -= check1.Length;
                }

                byte[] buf = new byte[i];
                if (check)
                    Buffer.BlockCopy(result, check1.Length, buf, 0, i);
                else
                {
                    check = true;
                    Buffer.BlockCopy(result, 0, buf, 0, i);
                }
                return buf;
            }
            check = true;
            return result;
        }
        
    }
}
