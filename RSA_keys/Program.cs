using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_keys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            

            while (true)
            {
                int key = 0;

                Console.Write("Введите длину ключа: ");
                string key_str = Console.ReadLine();
                while (!Int32.TryParse(key_str, out key) || key != 4)
                {
                    Console.WriteLine("Неправильная длина ключа!");
                    Console.Write("Введите длину ключа: ");
                    key_str = Console.ReadLine();
                }

                Random rand = new Random();
                bool isSimple = false;
                int p = 0, q = 0, N = 0, e = 0, fi = 0;

                while (fi <= 3)
                {
                    //выбор p
                    while (!isSimple)
                    {
                        isSimple = true;
                        p = rand.Next(3, 25);
                        for (int i = 2; i <= p / 2; i++)
                        {
                            if (p % i == 0)
                            {
                                isSimple = false;
                                break;
                            }
                        }
                    }

                    //выбор q
                    isSimple = false;
                    while (!isSimple)
                    {
                        isSimple = true;
                        q = rand.Next(3, 25);
                        for (int i = 2; i <= q / 2; i++)
                        {
                            if (q % i == 0 || q == p)
                            {
                                isSimple = false;
                                break;
                            }
                        }
                    }

                    //N
                    isSimple = true;
                    N = p * q;
                    fi = (p - 1) * (q - 1);
                }
                //Console.WriteLine("p = " + p + "\t" + "q = " + q + "\tN = " + N + "\tfi = " + fi);

                //Выбор значения e
                isSimple = false;
                while (!isSimple)
                {
                    isSimple = true;
                    e = rand.Next(3, fi - 1);
                    if (fi % e == 0)
                    {
                        isSimple = false;
                        continue;
                    }
                    for (int i = 2; i <= fi / 2; i++)
                    {
                        if (e % i == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                }

                //d
                long d = 0;
                for (int i = 1; ; i += fi)
                {
                    if (i % fi == 1 && i % e == 0)
                    {
                        d = i / e;
                        break;
                    }
                }

                Console.WriteLine("Открытый ключ: (" + e + ", " + N + ")\n" + "Закрытый ключ: (" + d + ", " + N + ")\n");
                Console.ReadKey();
            }
            }
    }
}
