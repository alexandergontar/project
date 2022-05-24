﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lesson1
{
    class Program
    {
        // выбор заданий по номеру урока
  
        static void Main(string[] args)
        {
            
            Console.Write("Выберите номер урока (например 3): ");

            int lessonNumber = 1;
            int.TryParse(Console.ReadLine(), out lessonNumber);            
            switch (lessonNumber)
            {
                case 1 :
                    PrimeNumberCalc.CheckPrime();
                    FibNumberCalc.CalculateFib();
                    break;
                case 2 :
                    Lesson2.LinkedListRun.CheckList();
                    Lesson2.ElementSearch.RunBinarySearch();
                    break;
                case 3 :  
                    Lesson3.TestDistance.Report(5);
                    Lesson3.Display.DisplayResults();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Проверьте ввод");
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}
