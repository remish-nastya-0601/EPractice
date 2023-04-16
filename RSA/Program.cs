using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            while (true)
            {
                Random rand = new Random();

                Console.WriteLine("Введите открытый ключ: (два числа)");
                Console.WriteLine("Первое число:");
                int e = int.Parse(Console.ReadLine());
                Console.WriteLine("Второе число:");
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine("Открытый ключ: (" + e + ", " + N + ")");
                
                try
                {
                    Console.WriteLine("Введите сообщение:");
                    string text = Console.ReadLine().ToLower();
                    int mes = 0;
                    while(!Int32.TryParse(text, out mes))
                    {
                        Console.WriteLine("Можно вводить только целые числа! Введите сообщение:");
                        text = Console.ReadLine().ToLower();
                    }
                    int res_encode = (int)BigInteger.ModPow(mes, e, N);
                    Console.WriteLine("Зашифрованное сообщение:\n" + res_encode);

                }
                catch
                {
                    Console.WriteLine("Неверный формат!");
                }
                Console.ReadKey();
            }
        }
    }
}

