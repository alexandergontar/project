using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитя ваше имя:");
            string guestName = Console.ReadLine();
            Console.WriteLine($"Сейчас [{DateTime.Now}], ваше Имя: {guestName}.");
            Console.ReadKey();
        }
    }
}
