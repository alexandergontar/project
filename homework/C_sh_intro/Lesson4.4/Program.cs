using System;
/*
 Calculate Fibbonacci by recursion
 */

namespace Lesson4._4
{
    class Program
    {

        static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return n - 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения элемента ряда Фибоначи.");
            Console.Write("Введите номер элемента ряда (1....n): ");
            string inputN = Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(inputN);
                if (n < 1)
                {
                    Console.WriteLine("Номер долден быть > 0");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Значение Фибоначи: " + Fib(n));
            }
            catch (Exception)
            {
                Console.WriteLine("Невернвй ввод.");
            }

            Console.ReadKey();
        }
    }
}
