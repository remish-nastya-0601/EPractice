using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA256
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string stroka = "";
                    Console.Write("Введите сообщение: ");
                    stroka = Console.ReadLine();
                    while (stroka == "")
                    {
                        Console.WriteLine("Было введено пустое сообщение!");
                        Console.Write("Введите сообщение: ");
                        stroka = Console.ReadLine();
                    }   

                    string res = Sha256(stroka);
                    Console.WriteLine("Хэшированное сообщение: " + res + "\n");
                }
                catch
                {
                    Console.WriteLine("Неправильный формат данных!\n");
                }
            }
        }

        public static string Sha256(string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
