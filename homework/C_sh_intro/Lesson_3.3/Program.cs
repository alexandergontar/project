using System;
/*
 display input line reversed
 */

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите любой текст: ");
                string inputLine = Console.ReadLine();
                string outputLine = String.Empty;
                for (int i = inputLine.Length - 1; i >= 0; i--)
                {
                    outputLine += inputLine[i];
                }
                Console.WriteLine($"Ваш текст задом наперед: {outputLine}");
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.WriteLine("Для выхода ESC");
                var keyPressed = Console.ReadKey();
                int keyCode = (int)keyPressed.KeyChar;
                if (keyCode == 27) break;

            }
        }
    }
}
