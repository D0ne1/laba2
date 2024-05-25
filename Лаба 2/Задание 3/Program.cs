using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            bool isNCorrect;
            int a1 = 1; // Первый элемент последовательности, задан в условии
            int an = 1; // Последний элемент последовательности
            int s = 0;
            Console.WriteLine("Введите сило N");
            do
            {
                num = Console.ReadLine();
                isNCorrect = int.TryParse(num, out int n);
                if (!isNCorrect)
                {
                    Console.WriteLine("Пожалуйста, введите корректное число");
                }
                else
                {
                    for (int i = 1; i < n; i++)
                    {
                        an += 2;
                    }
                    s = (a1 + an) * n / 2;
                }
            } while (!isNCorrect);
            Console.WriteLine($"Число S = {s}");
        }
    }
}
