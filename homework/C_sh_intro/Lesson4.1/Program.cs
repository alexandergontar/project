using System;
/*
 enter/display user list
 */

namespace Lesson4._1
{
    class Program
    {

        static string GetFullName(string firstname, string lastName, string patronymic) 
        {

            string fullName = $" {firstname} {patronymic} {lastName}";
            return fullName;
        }

        static string InputFullName() 
        {
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите фамлмя: ");
            string lastName = Console.ReadLine();
            string fullname = GetFullName(firstName, lastName, patronymic);
            Console.WriteLine("ФИО: "+ fullname);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            return fullname;
        }

        static string[] userFullNames; 
        static void Main(string[] args)
        {

            Console.Write("Введите число вносимых пользователей: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            userFullNames = new string[number];
            for (int i = 0; i < userFullNames.Length; i++)
            {
              userFullNames[i] = InputFullName();
            }
            Console.WriteLine("---- Весь список ----");
            for (int i = 0; i < userFullNames.Length; i++)
            {
                Console.WriteLine((i+1) +". ФИО: "+ userFullNames[i]);
            }
 
            Console.ReadKey();

        }
    }
}
