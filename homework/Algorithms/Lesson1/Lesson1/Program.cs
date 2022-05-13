using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        // алгоритм определения простого числа
  
        static void Main(string[] args)
        {
            Console.Write("Выберите номер урока (например 1): ");

            int lessonNumber = 1;
            int.TryParse(Console.ReadLine(), out lessonNumber);
            switch (lessonNumber)
            {
                case 1 :
                    PrimeNumberCalc.CheckPrime();
                    FibNumberCalc.CalculateFib();
                    break;
                default:
                    Console.WriteLine("Проверьте ввод");
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}
