using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
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
            //Console.ReadKey();
        }

        static void MatrixDisplayDiag<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j) Console.Write($"{matrix[i, j]} ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            //Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 9);
                }
            }
            Console.WriteLine("Исходная матрица:");
            Console.WriteLine();
            MatrixDisplay<int>(matrix);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Диагональ матрицы::");
            Console.WriteLine();
            MatrixDisplayDiag<int>(matrix);
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
