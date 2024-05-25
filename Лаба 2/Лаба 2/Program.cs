using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputn;
            string n;
            bool isNCorrect;
            bool isNCorrect2;
            int sum;
            int len;
            int num;
            Console.WriteLine("Введите длину последовательности: ");
            sum = 0;
            do
            {
                n = Console.ReadLine();
                isNCorrect = int.TryParse(n, out len);
                if (!isNCorrect | len <= 0 )
                {
                    Console.WriteLine("Введите, пожалуйста положительное, целое число (длину)");
                }
            } while (!isNCorrect);
            Console.WriteLine("Введите элемент последовательности");
            for (int i = 0; i < len; i++)
            {
                do
                {
                    Console.WriteLine($"Введите число {i + 1}: ");
                    inputn = Console.ReadLine();
                    isNCorrect2 = int.TryParse(inputn, out num);
                    if (!isNCorrect2)
                    {
                        Console.WriteLine("Введите корректный элемент последовательности");
                    }
                } while (!isNCorrect2);
                if (num % 2 ==0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
