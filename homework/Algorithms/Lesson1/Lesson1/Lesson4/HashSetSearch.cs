using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson1.Lesson4
{
    public class HashSetSearch
    {
        public static string Generate()
        {
            Random res = new Random(DateTime.Now.Ticks.GetHashCode());

            string str = "abcdefghijklmnopqrstuvwxyz";
            int size = new Random().Next(2, 10);
            StringBuilder ran = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                int x = res.Next(26);
                ran.Append(str[x]);
            }
            return ran.ToString();
        }

        public static void SearchString() 
        {
            HashSet<string> randStrings = new HashSet<string>();

            for (int i = 0; i < 10000; i++)
            {

                randStrings.Add(Generate());
                if (i == 5000)
                {
                    randStrings.Add("Santa Barbara");
                }
                Console.WriteLine();
                //Console.Clear();       
            }

            foreach (string s in randStrings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Число строк: " + randStrings.Count);
            Console.WriteLine("Поиск строки 'Santa Barbara' в строковом HashSet");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (randStrings.Contains("Santa Barbara"))
            {
                Console.WriteLine("Строка найдена");
            }
            else
            {
                Console.WriteLine("Строка не найдена");
            }
            sw.Stop();
            double mils = sw.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время поиска: {mils } млсек.");
            Console.ReadKey();
        }
    }
}
