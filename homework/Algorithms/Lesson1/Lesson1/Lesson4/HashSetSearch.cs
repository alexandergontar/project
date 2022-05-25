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
        const string Seed = "this is my secret seed ¾Ÿˇʣכ ↼⊜┲◗ blah balh";

        /// <summary>
        /// SHA генератор уникального ID в качестве случайной строки
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Уникальная строка</returns>
        static string GetProtectedID(int id)
        {
            using (var sha = System.Security.Cryptography.SHA1.Create())
            {
                return string.Join("", sha.ComputeHash(Encoding.UTF8.GetBytes(id.ToString() + Seed)).Select(b => b.ToString("X2"))) + id.ToString();
            }
        }
        /// <summary>
        /// генератор псевдослучайной строки
        /// псевдослучайной длины
        /// </summary>
        /// <returns></returns>
        static string Generate()
        {
            Random res = new Random(DateTime.Now.Ticks.GetHashCode());

            string str = "abcdefghijklmnopqrstuvwxyz";
            int size = new Random(DateTime.Now.Ticks.GetHashCode()).Next(2, 10); // длина строки
            StringBuilder ran = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                int x = res.Next(26);//позиция символа
                ran.Append(str[x]);
            }
            return ran.ToString();
        }


        /// <summary>
        /// Создает HashSet коллекцию
        /// случайных строк, вставляет одну заданную,
        /// потом производит ее поиск
        /// </summary>
        public static void SearchString(int N)
        {
            HashSet<string> randStrings = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                randStrings.Add(GetProtectedID(i));// 
                                                   //randStrings.Add(Generate()); // вызывает проблему массовых дупликатов

                if (i == N / 2)
                {
                    randStrings.Add("Santa Barbara"); // вставка заданной строки
                }
                /* при использовании Generate() добавление дополнительных
                   операций в цикл уменьшают число дупликатов
                   похоже, что Random() просто не успевает отработать нормально
                   при быстрых повторных вызовах в цикле
                  Console.WriteLine(); // как бы ненужная операция, но уменьшает число дупликатов
                                       // непонятно каким образом
                  Console.Clear(); // то же самое и еще эффективнее, но тормозит программу радикально  */
            }

            // распечатка всех строк для просмотра, если их немного
            /* foreach (string s in randStrings)
             {
                 Console.WriteLine(s);
             }*/
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
        }

        public static void CallSearchString()
        {
            Console.WriteLine("Несколько случайных замеров времени поиска для разного размера коллекции");
            SearchString(10000);
            Console.WriteLine("===============");
            SearchString(10000);
            Console.WriteLine("===============");
            SearchString(50000);
            Console.WriteLine("===============");
            SearchString(100000);
            Console.ReadKey(true);

        }
    }
}
