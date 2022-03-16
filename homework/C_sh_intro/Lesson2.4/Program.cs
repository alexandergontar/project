using System;

/*
 schematic check printout
 */

namespace Lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            decimal bread = 67.13m;
            decimal butter = 145.50m;
            decimal pelmeni = 280.00m;
            decimal total = bread + butter + pelmeni;
            

            Console.WriteLine();
            Console.WriteLine("     СПАСИБО");
            Console.WriteLine("    ЗА ПОКУПКУ");
            Console.WriteLine("--------------------");
            Console.WriteLine("---ООО Прасковей----");
            Console.WriteLine($"  Время: {dateTime}");
            Console.WriteLine("--------------------");
            Console.WriteLine(" Хлеб -------------" + bread.ToString());
            Console.WriteLine(" Масло ------------" + butter.ToString());
            Console.WriteLine(" Пельмени ---------" + pelmeni.ToString());
            Console.WriteLine(" ИТОГ:             " + total.ToString());
            Console.WriteLine("--------------------");
            Console.ReadKey();
        }
    }
}
