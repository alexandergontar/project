using System;
/*
  Determine season by month number
 */

namespace Lesson4._3
{
    class Program
    {

        enum Season { Winter, Spring, Summer, Autumn }
        static Season CalculateSeason(int monthNumber)
        {
            Season season = Season.Winter;
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                season = Season.Spring;
            }
            if (monthNumber >= 6 && monthNumber <= 8)
            {
                season = Season.Summer;
            }
            if (monthNumber >= 9 && monthNumber <= 11)
            {
                season = Season.Autumn;
            }

            return season;
        }

        static string DisplaySeason(Season season)
        {
            if (season == Season.Spring)
            {
                return "Весна";
            }
            else if (season == Season.Summer)
            {
                return "Лето";
            }
            else if (season == Season.Autumn)
            {
                return "Осень";
            }
            else
            {
                return "Зима";
            }


        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер месяца (1 - 12)");
                string monthCharacter = Console.ReadLine();
                int monthNumber;
                try
                {
                    monthNumber = Convert.ToInt32(monthCharacter);
                }
                catch (Exception)
                {
                    monthNumber = 0;
                }

                if (monthNumber < 1 || monthNumber > 12)
                {
                    Console.WriteLine("Ошибка, введите число от 1 до 12");
                    continue;
                }
                Season season = CalculateSeason(monthNumber);
                Console.WriteLine(season);
                Console.WriteLine(DisplaySeason(season));
                Console.WriteLine(@"Для продолжения нажмите любую клавишу
                  или ESC для выхода.");
                var keyPressed = Console.ReadKey();
                int keyCode = (int)keyPressed.KeyChar;
                if (keyCode == 27) break;
            }

        }
    }
}
