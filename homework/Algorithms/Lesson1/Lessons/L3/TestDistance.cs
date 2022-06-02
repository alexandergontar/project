using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L3
{
    public class TestDistance
    {
        /// <summary>
        /// Класс и структура координат точек
        /// </summary>
        public class PointClass
        {
            public double X;
            public double Y;
        }
        public struct PointStruct
        {
            public double X;
            public double Y;

        }
        /// <summary>
        /// Создает массив экземпляров классов
        /// </summary>
        /// <param name="arrLength">Длина массива</param>
        /// <returns> PointClass[]</returns>
        public  PointClass[] CreateArray(int arrLength)
        {
            PointClass[] array = new PointClass[arrLength];

            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                double x = rnd.Next(0, 100);
                double y = rnd.Next(0, 100);
                PointClass point = new PointClass() { X = x, Y = y };
                array[i] = point;
            }
            return array;
        }
        /// <summary>
        /// Создает массив структур
        /// </summary>
        /// <param name="arrLength">Длина массива</param>
        /// <returns>PointStruct[]</returns>
        public  PointStruct[] CreateStructArray(int arrLength)
        {
            PointStruct[] array = new PointStruct[arrLength];

            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                double x = rnd.Next(0, 100);
                double y = rnd.Next(0, 100);
                PointStruct point = new PointStruct() { X = x, Y = y };
                array[i] = point;
            }
            return array;
        }
        /// <summary>
        /// Вычисляет расстояние между 2-мя точками для структур
        /// </summary>
        /// <param name="pointOne">координаты точки 1</param>
        /// <param name="pointTwo">координаты точки 2</param>
        /// <returns>double</returns>

        public  double PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {

            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        /// <summary>
        /// Вычисляет расстояние между 2-мя точками для классов
        /// </summary>
        /// <param name="pointOne">координаты точки 1</param>
        /// <param name="pointTwo">координаты точки 2</param>
        /// <returns>double</returns>
        public  double PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Тестирует производительность на массиве классов
        /// </summary>
        /// <param name="number">Длина массива</param>
        /// <returns>TimeSpan</returns>
        public  TimeSpan Test1(int number)
        {

            PointClass[] array1 = CreateArray(number);
            PointClass[] array2 = CreateArray(number);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < number; i++)
            {
                PointDistance(array1[i], array2[i]);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            return ts;
        }
        /// <summary>
        /// Тестирует производительность на массиве структур
        /// </summary>
        /// <param name="number">Длина массива</param>
        /// <returns>TimeSpan</returns>
        public  TimeSpan Test2(int number)
        {
            PointStruct point1 = new PointStruct { X = 0, Y = 0 };
            PointStruct point2 = new PointStruct { X = 10, Y = 10 };
            PointStruct[] array1 = CreateStructArray(number);
            PointStruct[] array2 = CreateStructArray(number);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < number; i++)
            {
                PointDistance(array1[i], array2[i]);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            return ts;
        }

        /// <summary>
        /// Вывод результатов
        /// </summary>
        public  void Report(int measureNumber)
        {
            TimeSpan ts1, ts2;
            float ratio;
            for (int i = 0; i < measureNumber; i++)
            {
                Console.Write("Массив классов, точек: 1000000- ");
                ts1 = Test1(1000000);
                Console.Write("Массив структур, точек: 1000000- ");
                ts2 = Test2(1000000);
                ratio = (float)ts1.Milliseconds / (float)ts2.Milliseconds;
                Console.WriteLine($"Соотношение: {ratio}");
                Console.Write("Массив классов, точек: 5000000- ");
                ts1 = Test1(5000000);
                Console.Write("Массив структур, точек: 5000000- ");
                ts2 = Test2(5000000);
                ratio = (float)ts1.Milliseconds / (float)ts2.Milliseconds;
                Console.WriteLine($"Соотношение: {ratio}");
                Console.WriteLine("=======================");
            }
        }
    }
}
