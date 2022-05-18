using System;


namespace Lesson8
{
    class Program
    {
        static void DisplaySettings()
        {
            if (Properties.Settings.Default.UserName.Length > 0)
            {
                string userName = Properties.Settings.Default.UserName;
                string userAge = Properties.Settings.Default.Age;
                string userOccupation = Properties.Settings.Default.Occupation;
                Console.WriteLine($"{userName}, {userAge}, {userOccupation}!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);
            try
            {
                DisplaySettings();
            }
            catch (Exception)
            {
                throw;
            }
            Console.WriteLine("Введите Ваше имя:");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст:");
            Properties.Settings.Default.Age = Console.ReadLine();
            Console.WriteLine("Введите Ваш род деятельности:");
            Properties.Settings.Default.Occupation = Console.ReadLine();
            Properties.Settings.Default.Save();
            try
            {
                DisplaySettings();
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();

        }
    }
}
