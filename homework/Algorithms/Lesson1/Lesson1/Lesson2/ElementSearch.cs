using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson2
{
    public class ElementSearch
    {
        static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        static void TestBinarySearch(BinTestCase testCase)
        {
            Console.WriteLine("Упорядоченный массив:");
            for (int i = 0; i < testCase.inputArray.Length; i++)
            {
                Console.Write($"{testCase.inputArray[i]} ");
            }
            Console.WriteLine();
            int index = BinarySearch(testCase.inputArray, testCase.searchValue);
            Console.WriteLine($"Для {testCase.searchValue} на входе индех: {index}");
            if (index == testCase.expectedIndex)
            {
                Console.WriteLine("TEST PASSED");
            }
            else
            {
                Console.WriteLine("TEST NOT PASSED");
            }

        }

        public static void RunBinarySearch() 
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("Упорядоченный массив:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            int index = BinarySearch(arr1, 10);
            Console.Write("Для элемента 10 индекс: ");
            Console.WriteLine(index);

            BinTestCase test1 = new BinTestCase()
            {
                inputArray = new int[] { 1, 2, 11, 17, 19 },
                searchValue = 1,
                expectedIndex = 0
            };
            BinTestCase test2 = new BinTestCase()
            {
                inputArray = new int[] { 1, 2, 11, 17, 19 },
                searchValue = 19,
                expectedIndex = 4
            };
            BinTestCase test3 = new BinTestCase()
            {
                inputArray = new int[] { 1, 2, 11, 17, 19 },
                searchValue = 20,
                expectedIndex = -1
            };
            TestBinarySearch(test1);
            TestBinarySearch(test2);
            TestBinarySearch(test3);
            Console.ReadKey(true);
        }
    }
}
