using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._2
{
    class Program
    {
        // модифицирууем исходный метод для расчета числа элементов и операций
        public static (int x, int y) StrangeSum(int[] inputArray) 
        {
            int sum = 0;
            int O = 0; // число операций
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y; // -выполняемая функция   
                        O++; // счетчик операций
                    }
                }
            }
            // return sum; O(1) - единичная операция вывода
            return (inputArray.Length, O); // возврат числа элемнтов и операций
        }

        // вывод на консоль
        public static void Display(int N, int O) 
        {
            Console.WriteLine($"Число элементов: {N}");
            Console.WriteLine($"Число циклических операций: {O}");
        }


        static void Main(string[] args)
        {
            
            int[] inputArray1 = new int[] { 1, 2 };
            int N, O; 
            (N, O) = StrangeSum(inputArray1);
            Display(N, O); // 2 элемента - 8 операций
            int[] inputArray2 = new int[] { 1, 2, 3 };
            (N, O) = StrangeSum(inputArray2);
            Display(N, O); // 3 элемента - 27 операций
            int[] inputArray3 = new int[] { 1, 2, 3, 4 };
            (N, O) = StrangeSum(inputArray3);
            Display(N, O); // 4 элемента - 64 операций
            Console.WriteLine("плюс O[1] для return sum");
            Console.WriteLine("Всего: O[N^3 +1]");
            Console.ReadKey();
        }
    }
}
