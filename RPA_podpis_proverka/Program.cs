using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RPA_podpis_proverka
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
                    Random rand = new Random();

                    Console.WriteLine("Введите открытый ключ: (два числа)");
                    Console.Write("Первое число:");
                    int e = int.Parse(Console.ReadLine());
                    Console.Write("Второе число:");
                    int N = int.Parse(Console.ReadLine());

                    Console.WriteLine("Открытый ключ: (" + e + ", " + N + ")" );
                    Console.WriteLine("Введите сообщение:");
                    string text = Console.ReadLine().ToLower();
                    int mes = 0;
                    while (!Int32.TryParse(text, out mes))
                    {
                        Console.WriteLine("Можно вводить только целые числа! \nВведите сообщение:");
                        text = Console.ReadLine().ToLower();
                    }

                    Console.WriteLine("Введите подпись: ");
                    string podp = Console.ReadLine().ToLower();
                    int podp_num = 0;
                    while (!Int32.TryParse(podp, out podp_num))
                    {
                        Console.WriteLine("Подпись должна быть целым числом! \nВведите сообщение:");
                        text = Console.ReadLine().ToLower();
                    }

                    int res = (int)BigInteger.ModPow(podp_num, e, N);

                    Console.Write("\nПроверка подписи: " + ((res == mes) ? "Подпись верна\n\n": "Подпись не верна\n\n"));
                    
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Неверный формат!\n");
                }
                
            }
        }
    }
}
