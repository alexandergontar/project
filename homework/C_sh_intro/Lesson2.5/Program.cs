using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static int officeOneSchedule = 0b0011110;
        static int officeTwoSchedule = 0b1111111;

        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (например: понедельник-1...воскресенье-7): ");
            dayNumber = Convert.ToInt16(Console.ReadLine());
            var x = (Day)(dayNumber - 1);
            day = Convert.ToString(x);
            dayMask = (int)Math.Pow(2, dayNumber - 1);
            Console.WriteLine(day);
            int officeOneWork = officeOneSchedule & dayMask;
            int officeTwoWork = officeTwoSchedule & dayMask;
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
