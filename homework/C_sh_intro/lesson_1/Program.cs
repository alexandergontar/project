using System;
/* This is the first
 * Console input/output 
 * example.
 */ 
namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введитя ваше имя: "); // prompt to put user's name
            string guestName = Console.ReadLine(); // put string in variable
            Console.WriteLine($"Привет, {guestName}, сегодня [{DateTime.Now}] "); // console output         
            Console.ReadKey(); // wait for any key to be pressed
        }
    }
}
