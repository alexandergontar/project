using System;
/*
 Display phone list from 5x2 array
 */

namespace Lesson_3._2
{
    class Program
    {  

        static void MatrixDisplay<T>(T[,] matrix)
        {
            Console.WriteLine("Display phone list from 5x2 array:");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            
            string[,] contacts = new string[5, 2]{
             {"Иван Петов", "+7 812 337-00-11, ipetrov@mail.ru"},
             {"Василий Иванов", "+7 812 337-00-11, vivanov@gmail.ru"},
             {"Николай Соколов", "+7 812 337-00-11, niksokol@yandex.ru"},
             {"Дмитрий Рыков", "+7 812 337-00-11, dimrykov@rambler.ru"},
             {"Дарья Земскова", "+7 812 337-00-11, dzemskova@mail.ru"}
            };

            MatrixDisplay<string>(contacts);
            Console.WriteLine();
        }
    }
}
