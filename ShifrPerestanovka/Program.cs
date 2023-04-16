using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifrPerestanovka
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
                    Console.Write("Введите сообщение: ");
                    string stroka = Console.ReadLine();
                    while (stroka == "")
                    {
                        Console.WriteLine("Было введено пустое сообщение!");
                        Console.Write("Введите сообщение: ");
                        stroka = Console.ReadLine();
                    }
                    Console.Write("Введите ключ: ");
                    string key_str = Console.ReadLine();
                    while (key_str == "")
                    {
                        Console.WriteLine("Было введено пустое сообщение!");
                        Console.Write("Введите сообщение: ");
                        key_str = Console.ReadLine();
                    }
                    int key;
                    bool is_key = true;
                    string dist_key_str = string.Join("", key_str.Distinct().ToArray());
                    //проверка на правильность ввода ключа
                    if (!Int32.TryParse(key_str, out key) ||!dist_key_str.Equals(key_str)) is_key = false;
                    else
                    {
                        for(int i=1; i <= key_str.Length; i++)
                        {
                            if(key_str.IndexOf(i.ToString()) == -1)
                            {
                                is_key = false;
                                break;
                            }
                        }
                    }

                    while (!is_key)
                    {
                        Console.Write("Ключ должен быть целочисленным числом, содержащем перемешанную последовательность чисел от 1!\nВведите ключ: ");
                        key_str = Console.ReadLine();
                        dist_key_str = string.Join("", key_str.Distinct().ToArray());
                        is_key = true;
                        if (!Int32.TryParse(key_str, out key) || !dist_key_str.Equals(key_str)) is_key = false;
                        else
                        {                          
                            for (int i = 1; i <= key_str.Length; i++)
                            {
                                if (key_str.IndexOf(i.ToString()) == -1)
                                {
                                    is_key = false;
                                    break;
                                }
                            }
                        }
                    }

                    int array_strings = (int)Math.Ceiling(stroka.Length * 1.0 / key_str.Length);
                    string[,] array = new string[array_strings, key_str.Length];
                    string res = "";
                    for(int i = 0; i< array_strings; i++)
                    {
                        for(int j=0; j< key_str.Length; j++)
                        {
                            if (i * key_str.Length + j < stroka.Length)
                                array[i, j] = stroka[i * key_str.Length + j].ToString();
                            else array[i, j] = "";
                        }
                    }

                    for (int i = 0; i < key_str.Length; i++)
                    {
                        for (int j = 0; j < array_strings; j++)
                        {                           
                            res += array[j, key_str.IndexOf((i + 1).ToString())]; //2134
                        }
                    }
                    Console.WriteLine("Зашифрованная строка: " + res + "\n");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Неправильный формат данных!\n");
                }
            }
        }


    }
}
