using System;
/*
   simple using binary mask example
 */

namespace Lesson2._5
{
    class Program
    {

        enum Day
        {
            понедельник, вторник, среда, четверг, пятница, суббота,
            воскресенье
        };

        static string day;
        static int dayNumber;
        static int dayMask;
        static int officeOneSchedule = 0b0011110; // office 1 working days
        static int officeTwoSchedule = 0b1111111; // office 2 working days

        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (например: понедельник-1...воскресенье-7): ");
            dayNumber = Convert.ToInt16(Console.ReadLine());
            if (dayNumber < 1 || dayNumber > 7) 
            {
                Console.WriteLine("Значение номера дня вне интервала.");
                Console.ReadKey();
                return;
            }
            var x = (Day)(dayNumber - 1);
            day = Convert.ToString(x); // day by number
            dayMask = (int)Math.Pow(2, dayNumber - 1); // current day mask calculation
            Console.WriteLine(day);
            int officeOneWork = officeOneSchedule & dayMask; // apply mask to office 1 working days
            int officeTwoWork = officeTwoSchedule & dayMask; // apply mask to office 2 working days
            if (officeOneWork != 0)
            {
                if (officeTwoWork != 0)
                {
                    Console.WriteLine("Офис 1 и Офис 2 открыты");
                }
                else
                {
                    Console.WriteLine("Офис 1 открыт, а Офис 2 закрыт");
                }
            }
            else if (officeTwoWork != 0)
            {
                Console.WriteLine("Открыт Офис 2.");
            }
            else
            {
                Console.WriteLine("Офис один и Офис 2 закрыты. ");
            }

            Console.ReadKey();
        }
    }
}
