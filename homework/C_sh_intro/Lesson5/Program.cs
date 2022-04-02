using System;
using System.IO;
/*
 save data entries to file
 */

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = "itemsData.txt";
            string[] data = new string[3];
            while (true)
            { 
                Console.Write("Введите наименование товара: ");
                data[0] = Console.ReadLine();
                Console.Write("Введите индекс товара: ");
                data[1] = Console.ReadLine();
                Console.Write("Введите цену: ");
                data[2] = Console.ReadLine(); 
                File.AppendAllLines(filename, data);
                File.AppendAllText(filename, Environment.NewLine);
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.WriteLine("ESC завершения ввода.");
                char pressedKey = Console.ReadKey().KeyChar;
                int keyNum = (int)pressedKey;
                if (keyNum == 27) break;
            }
            string fileText = File.ReadAllText(filename);
            Console.WriteLine();
            Console.WriteLine(fileText);           
            Console.ReadKey();

        }
    }
}
