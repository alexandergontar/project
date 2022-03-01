using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._2
{
    class Program
    {
        static int monthNumber;
        static string month;
        enum Month
        {
            Январь, Февраль, Март, Апрель, Май, Июнь,
            Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
        };
        static void Main(string[] args)
        {
            Console.Write("Введите номер текущего месяца: ");
            monthNumber = Convert.ToInt16(Console.ReadLine());
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                var x = (Month)(monthNumber - 1);
                month = Convert.ToString(x);
                Console.WriteLine($"Сейчас {month} месяц.");
                if ((monthNumber == 1 || monthNumber == 2 || monthNumber == 12))
                {
                    Console.Write("Введите максимальную суточную температуру: ");
                    double tempMax = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите минимальную суточную температуру: ");
                    double tempMin = Convert.ToDouble(Console.ReadLine());
                    double tempAvg = (tempMax + tempMin) / 2;
                    Console.WriteLine($"Среднесуточная температура: {tempAvg} градусов.");
                    if (tempAvg > 0)
                    {
                        Console.WriteLine("Дождливая зима.");
                    }
                }

            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }

            Console.ReadKey();
        }
    }
}
