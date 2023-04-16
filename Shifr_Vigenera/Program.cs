using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr_Vigenera
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.InputEncoding = Encoding.Unicode;
                    const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

                    Console.Write("Напишите строку: ");
                    string stroka = Console.ReadLine().ToUpper();
                    Console.Write("Введите ключ: ");
                    string key = Console.ReadLine().ToUpper();
                    string zashifr = Shifr(alphabet, stroka, key);
                    string rasshifr = Shifr(alphabet, zashifr, key, false);
                    Console.WriteLine("Зашифрованая строка: " + zashifr);
                    Console.WriteLine("Расшифрованная строка: " + rasshifr + "\n");

                }
                catch
                {
                    Console.WriteLine("Неправильный формат данных!\n");
                }
            }

        }

        public static string Shifr(string alphabet, string str, string key, bool is_encrypt = true)
        {
            var res = "";
            var q = alphabet.Length;

            for (int i = 0, j = 0; i < str.Length; i++)
            {
                var alphabet_index = alphabet.IndexOf(str[i]);
                var key_index = alphabet.IndexOf(key[j % key.Length]);
                if (alphabet_index < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    res += str[i].ToString();
                }
                else
                {
                    j++;
                    res += alphabet[(q + alphabet_index + ((is_encrypt ? 1 : -1) * key_index)) % q].ToString();
                }
            }

            return res;
        }

       

    }
}
