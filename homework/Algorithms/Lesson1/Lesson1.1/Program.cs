using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._1
{
    class Program
    {

        static void TestFib(Test test, bool rec) 
        {
            try
            {
                int result = 0;
                if (rec)
                {
                    result = FibRec(test.Input);
                }
                else 
                { 
                     result = Fib(test.Input);
                }                 

                if (result == test.ExpectedResult)
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
                if (ex.GetType().Name == test.ExpectedException)
                {
                    Console.WriteLine("TEST PASSED");
                }
                else 
                {
                    Console.WriteLine("TEST NOT PASSED");
                }
                
            }
        }
        static int Fib(int end) 
        {
            if (end < 1) throw new ArgumentException("Ввод должен быть > 0");
            if (end ==1) return 0;
            if (end == 2 || end == 3) return 1;

            int num0 = 0;
            int num1 = 1;
            int num2 = 0;

            //Первые две переменные выводим вне цикла:
           // Console.Write(num0 + " " + num1 + " ");
            for (int i = 3; i <= end; i++)
            {
                num2 = num0 + num1;

                //Каждый следующий элемент выводим в цикле:
                //Console.Write(num2 + " ");

                //Предыдущим двум переменным присваиваем новые значения:
                num0 = num1;
                num1 = num2;
            }
            //Console.WriteLine();
            //Console.WriteLine(num2);
            return num2;
        }

        static int FibRec(int n) 
        {
            if (n < 1) throw new ArgumentException("Ввод должен быть > 0");
            if (n==1 || n==2) 
            {
                return n - 1;
            }
            int result = FibRec(n - 1) + FibRec(n - 2);            
            return FibRec(n - 1)+FibRec(n - 2);            
        }
        static void Main(string[] args)
        {
            int end=1;
            Console.Write("Введите порядковый номер члена ряда: ");
            try
            {
              end = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
            //int result = Fib(end);            
            Console.WriteLine("Значение-" + Fib(end));
            Console.WriteLine("Рекурсивно:");
            Console.WriteLine("Значение-" + FibRec(end));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            var test1 = new Test() {
                Input = 8,
                ExpectedResult = 13
            };
            var test2 = new Test()
            {
                Input = 7,
                ExpectedResult = 8
            };
            var test3 = new Test()
            {
                Input = 5,
                ExpectedResult = 3
            };
            var test4 = new Test()
            {
                Input = 0,
                ExpectedException = "ArgumentException"
            };
            var test5 = new Test()
            {
                Input = -1,
                ExpectedException = "ArgumentException"
            };

            TestFib(test1, false); TestFib(test1, true);
            TestFib(test2, false); TestFib(test2, true);
            TestFib(test3, false); TestFib(test3, true);
            TestFib(test4, false); TestFib(test4, true);
            TestFib(test5, false); TestFib(test5, true);
            Console.ReadKey();
        }
    }
}
