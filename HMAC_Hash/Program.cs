using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMAC_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string stroka = "", key = "";
                    Console.Write("Введите сообщение: ");
                    stroka = Console.ReadLine();
                    while (stroka == "")
                    {
                        Console.WriteLine("Было введено пустое сообщение!");
                        Console.Write("Введите сообщение: ");
                        stroka = Console.ReadLine();
                    }
                    Console.Write("Введите ключ: ");
                    key = Console.ReadLine();
                    while (key == "")
                    {
                        Console.WriteLine("Был введен пустой ключ!");
                        Console.Write("Введите ключ: ");
                        key = Console.ReadLine();
                    }
                    string res = HMAC(stroka, key);
                    Console.WriteLine("Хэшированное сообщение: " + res + "\n");
                }
                catch
                {
                    Console.WriteLine("Неправильный формат данных!\n");
                }
            }
        }

        public static string HMAC(string str, string key)
        {
            byte[] bkey = Encoding.Unicode.GetBytes(key);
            using (var hmac = new HMACSHA1(bkey))
            {
                byte[] bstr = Encoding.Default.GetBytes(str);
                return Convert.ToBase64String(hmac.ComputeHash(bstr));
            }
        }
    }
}
