using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L8
{
    public class CountingSorting
    {
        void CountingSort(int[] array)
        {            

            Console.WriteLine( "Исходный массив чисел: ");
            foreach (int a in array)
                Console.Write(a + " ");

            int[] sortedArray = new int[array.Length];

            // находим наименьшее и наибольшие значения
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // создаем массив частот попаданий для всех возможных значений
            int[] counts = new int[maxVal - minVal + 1];

            // заполняем "гистограмму" количеств попаданий для каждого значения
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }
           

            ///пересчет counts на суммы элемента с предыдущим дают 
            /// новые позиции чисел исходного массива 
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // расстановка по позициям
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            Console.WriteLine("\n" + "Отсортированный массив: ");
            foreach (int a in sortedArray)
                Console.Write(a + " ");
            Console.Write("\n");
        }

        public void Sort() 
        {
            // задаем массив
            int[] array = new int[10]
          {
             2, 3, -7, 11, 0, 8, 22, 67, 51, 6
          };
            // сортируем
            CountingSort(array);
        }

    }
}
