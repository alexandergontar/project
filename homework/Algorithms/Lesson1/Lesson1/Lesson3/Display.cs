using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson1.Lesson3
{
    public class Display
    {
        /// <summary>
        /// Вывод текстового файла
        /// </summary>
        /// <param name="path"> Путь к файлу</param>
        static void DispTextFile(string path) 
        {
            string[] result = File.ReadAllLines(path);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine("Для продоления нажмите любую клавишу");
            Console.ReadKey(true);
        }
        /// <summary>
        /// Вывод реультатов тестирования и исходного кода
        /// </summary>
        public static void DisplayResults()
        {  
            // получаем путь к папке проекта 
            string path = Directory.GetCurrentDirectory();
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;
            // добавляем относительные пути к файлам с отчетом и исходным кодом
            string path1 = Path.Combine(path, @"Lesson3\BenchMark.Program.BechmarkClass-report-github.md");
            string path2 = Path.Combine(path, @"Lesson3\Source.src");
           //Вывод содержимого
            Console.WriteLine();
            Console.WriteLine("Результат тестов:");
            Console.WriteLine();
            DispTextFile(path1);
            Console.WriteLine();
            Console.WriteLine("Исходный код:");
            Console.WriteLine("======================================");
            DispTextFile(path2);
        }
    }
}
