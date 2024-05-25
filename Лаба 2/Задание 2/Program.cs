using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string kr1;
            string kr2;
            int k1;
            int k2;
            int number;
            int count = 0;
            bool isK1Correct;
            bool isK2Correct;
            bool isInCorrect;
            Console.WriteLine("Введите целое число K1");
            do
            {
                kr1 = Console.ReadLine();
                isK1Correct = int.TryParse(kr1, out k1);
                if (!isK1Correct | k1 == 0)
                {
                    Console.WriteLine("Введено некорректное число, вы ввели не целое число, либо нечисло, либо 0");
                }
            } while (!isK1Correct);
            Console.WriteLine("Введите целое число K2");
            do
            {
                kr2 = Console.ReadLine();
                isK2Correct = int.TryParse(kr2, out k2);
                if (!isK2Correct | k2 == 0)
                {
                    Console.WriteLine("Введено некорректное число, вы ввели не целое число, либо нечисло, либо 0");
                }
            } while (!isK2Correct);
            do
            {
                Console.WriteLine("Введите числа последовательности, в конце 0");
                do
                {
                    input = Console.ReadLine();
                    isInCorrect = int.TryParse(input, out number);
                    if (!isInCorrect)
                    {
                        Console.WriteLine("Введите корректный элемент последовательности");
                    }
                } while (input != "0");
                if (number % k1 == 0 && number % k2 != 0)
                {
                    count++;
                }  
            } while (!isInCorrect);
         Console.WriteLine($"Количество чисел, кратных К1 и не кратных К2: {count}");
        }
    }
}
