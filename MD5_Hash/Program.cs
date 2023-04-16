using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите сообщение: ");
                    string stroka = Console.ReadLine();

                    string res = CreateMD5(stroka);
                    Console.WriteLine("Хэшированное сообщение: " + res + "\n");
                }
                catch
                {
                    Console.WriteLine("Неправильный формат данных!\n");
                }
            }
        }

        public static string CreateMD5(string message)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);
                byte[] hashBytes = md5.ComputeHash(messageBytes);

                 StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
