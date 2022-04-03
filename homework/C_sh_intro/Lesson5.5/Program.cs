using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Lesson5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "tasks.json";
            string json;
            ToDo[] items;
            if (File.Exists(fileName))
            {
                DisplayJson.DisplayContent(fileName, out json, out items);
            }
            else
            {
                DisplayJson.FillContent(fileName, out json, out items);
                DisplayJson.DisplayContent(fileName, out json, out items);
            }
            Console.Write("Введите номер завершенного пункта или 0 для выхода: ");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                n = 0;
            }
            if (n == 0) return;
            items[n - 1].IsDone = true;
            json = JsonSerializer.Serialize(items);
            File.WriteAllText(fileName, json);
            DisplayJson.DisplayContent(fileName, out json, out items);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
