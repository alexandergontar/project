using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class PrimeNumberCalc
    {
        static bool PrimeNumber(string n)
        {
            bool result = false;
            int number;
            try
            {
                number = Convert.ToInt32(n);
            }
            catch (Exception)
            {
                throw new FormatException("Bad input");
            }

            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                Console.WriteLine("Простое");
                result = true;
            }
            else
            {
                Console.WriteLine("Не простое");
                result = false;
            }
            return result;
        }

        static void TestPrimeNumber(TestCase testCase)
        {
            Console.WriteLine($"Тест для {testCase.Input} на входе");
            try
            {
                bool result = PrimeNumber(testCase.Input);
                if (result == testCase.ExpectedResult)
                {
                    Console.WriteLine("TEST PASSED");
                }
                else
                {
                    Console.WriteLine("TEST NOT PASSED");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);

                if (ex.GetType().Name == testCase.ExceptionName)
                {
                    Console.WriteLine("TEST PASSED");
                }
                else
                {
                    Console.WriteLine("TEST NOT PASSED");
                }

            }
        }

        public static void CheckPrime() 
        {
            Console.WriteLine("Определить простое ли число.");
            Console.Write("Введите число: ");
            string n = Console.ReadLine();
            bool result = false;
            try
            {
                result = PrimeNumber(n);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(result);
            }

            TestCase test1 = new TestCase()
            {
                Input = "7",
                ExpectedResult = true
            };
            TestCase test2 = new TestCase()
            {
                Input = "11",
                ExpectedResult = true
            };
            TestCase test3 = new TestCase()
            {
                Input = "9",
                ExpectedResult = false
            };
            TestCase test4 = new TestCase()
            {
                Input = "1.2",
                ExceptionName = "FormatException"
            };
            TestCase test5 = new TestCase()
            {
                Input = "2F",
                ExceptionName = "FormatException"
            };

            TestPrimeNumber(test1);
            TestPrimeNumber(test2);
            TestPrimeNumber(test3);
            TestPrimeNumber(test4);
            TestPrimeNumber(test5);

            Console.ReadKey(true);
        }

    }
}
