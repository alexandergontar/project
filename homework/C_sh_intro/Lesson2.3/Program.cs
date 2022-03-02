using System;
/*
 determine if number is odd or even
 */

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите любое целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(" Ваше число четное.");
            }
            else
            {
                Console.WriteLine(" Ваше число нечетное.");
            }

            Console.ReadKey();
        }
    }
}
