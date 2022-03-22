using System;
/*
 parse and add up space separated numbers
 */

namespace Lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ряд целых чисел, разделенных пробелом: ");
            string inputString = Console.ReadLine();
            inputString += " ";
            string temp = String.Empty;
            int count = 0;
            int[] numbAarray = new int[10];
            for (int i = 0; i < inputString.Length; i++)
            {
                char c = inputString[i];
                if (Char.IsDigit(c))
                {
                    temp += c;
                }
                else if (temp.Length > 0)
                {
                    Console.WriteLine(temp);
                    numbAarray[count] = Convert.ToInt32(temp);
                    temp = String.Empty;
                    count++;
                }
            }

            int sum = 0;
            for (int i = 0; i < numbAarray.Length; i++)
            {
                sum += numbAarray[i];
            }
            Console.WriteLine("Сумма чисел: " + sum.ToString());
            Console.ReadKey();
        }
    }
}
