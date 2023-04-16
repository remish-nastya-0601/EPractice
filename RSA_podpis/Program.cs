using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RSA_podpis
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
                
                try
                {
                    Console.WriteLine("Введите открытый ключ: (два числа)");
                    Console.WriteLine("Первое число:");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Второе число:");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите закрытый ключ: (одно число)");
                    int d = int.Parse(Console.ReadLine());

                    Console.WriteLine("Открытый ключ: (" + e + ", " + N + ")\n" + "Закрытый ключ: (" + d + ", " + N + ")");

                    Console.WriteLine("Введите сообщение:");
                    string text = Console.ReadLine().ToLower();
                    int mes = 0;
                    while (!Int32.TryParse(text, out mes))
                    {
                        Console.WriteLine("Можно вводить только целые числа! \nВведите сообщение:");
                        text = Console.ReadLine().ToLower();
                    }
                    int res = (int)BigInteger.ModPow(mes, d, N);

                    Console.WriteLine();
                    Console.WriteLine("Подпись: " + res);

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
