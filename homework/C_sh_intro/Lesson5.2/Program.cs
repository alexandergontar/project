using System;
using System.IO;
/*
 save current program start date/time
 */
namespace Lesson5._2
{
    class Program
    {
        static string filename = "Startup.txt";
        static void Main(string[] args)
        {

            string dateTime = DateTime.Now.ToString();
            Console.WriteLine("Сейчас: " + dateTime);
            Console.WriteLine();
            File.AppendAllText(filename, dateTime);
            File.AppendAllText(filename, Environment.NewLine);
            string fileText = File.ReadAllText(filename);
            string[] fileLines = File.ReadAllLines(filename);
            Console.WriteLine("Первый старт: " + fileLines[0]);
            if (fileLines.Length >= 2)
            {
                Console.WriteLine("Последний старт: " + fileLines[fileLines.Length - 2]);
            }
            Console.WriteLine("Весь журнал: ");
            Console.WriteLine(fileText);
            Console.ReadKey();
        }
    }
}