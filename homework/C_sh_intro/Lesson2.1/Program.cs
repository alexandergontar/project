using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную суточную температуру: ");
            double tempMax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную суточную температуру: ");
            double tempMin = Convert.ToDouble(Console.ReadLine());
            double tempAvg = (tempMax + tempMin) / 2;
            Console.WriteLine($"Среднесуточная температура: {tempAvg} градусов.");
            if (tempAvg > 0)
            {                                  ;
                int monthNumber = DateTime.Now.Month;
                if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
                    Console.WriteLine("Дождливая зима.");
            }
            Console.ReadKey();

        }
    }
}
