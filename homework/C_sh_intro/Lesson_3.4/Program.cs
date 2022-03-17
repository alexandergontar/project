using System;
/*
 Schematic naval battle field display
 */

namespace Lesson_3._4
{
    class Program
    {
        static void MatrixDisplay<T>(T[,] matrix)
        {
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
            Console.WriteLine(" -------Морской бой-------");
            Console.WriteLine("(крестики - корабли, нули пустые места) ");
            Console.WriteLine();
            string[,] battleField = new string[10, 10] {
            {"X","0","X","0","X","0","0","0","X","0"},
            {"X","0","X","0","X","0","0","0","X","0"},
            {"X","0","X","0","X","X","0","0","0","X"},
            {"X","0","0","0","0","0","0","0","0","X"},
            {"0","0","X","X","X","0","0","0","0","0"},
            {"0","0","0","0","0","0","0","0","0","0"},
            {"0","0","0","X","X","X","0","0","X","0"},
            {"0","0","0","0","0","0","0","0","X","0"},
            {"0","0","0","0","X","0","0","0","0","0"},
            {"X","X","X","0","X","0","0","X","X","X"}
            };
            MatrixDisplay<string>(battleField);
        }
    }
}
