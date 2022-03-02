using System;

/* 
 * Average temp calculation
 */
namespace Lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // temp input
            Console.Write("Введите максимальную суточную температуру: ");
            double tempMax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную суточную температуру: ");
            double tempMin = Convert.ToDouble(Console.ReadLine());
            double tempAvg = (tempMax + tempMin) / 2;
            Console.WriteLine($"Среднесуточная температура: {tempAvg} градусов.");
            if (tempAvg > 0) // if temp > 0 and it is winter time display "Дождливая зима" 
            {                                  ;
                int monthNumber = DateTime.Now.Month;
                if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
                    Console.WriteLine("Дождливая зима.");
            }
            Console.ReadKey();

        }
    }
}
