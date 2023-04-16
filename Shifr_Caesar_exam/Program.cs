using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr_Caesar_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                try
                {
                    Console.Write("Введите строку: ");
                    string str = Console.ReadLine();
                    Console.Write("Введите ключ: ");
                    int secretKey = Convert.ToInt32(Console.ReadLine());
                    string encryptedStr = Encrypt(str, secretKey);
                    Console.WriteLine("Зашифрованное сообщение: {0}", encryptedStr);
                    Console.WriteLine("Расшифрованное сообщение: {0}", Decrypt(encryptedStr, secretKey));
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Неправильный формат!\n");
                }
            }
        }

        //шифрование
        public static string Encrypt(string plainMessage, int key)
        { 
            return Shifr(plainMessage, key); 
        }

        //дешифрование
        public static string Decrypt(string encryptedMessage, int key)
        {
            return Shifr(encryptedMessage, -key);
        }

        //преобразование текста
        public static string Shifr(string str, int key)
        {
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToLower();
            int alfabet_length = alfabet.Length;
            string res = "";
            foreach (char el in str)
            {
                int index = alfabet.IndexOf(el);
                if (index < 0)
                {
                    //если символ не найден, то просто его добавить
                    res += el.ToString();
                }
                else
                {
                    int res_index = (alfabet_length + index + key) % alfabet_length;
                    res += alfabet[res_index];
                }
            }
            return res;
        }
    }
}
