using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Lesson5._5
{
    public static class DisplayJson
    {
        public static void DisplayContent(string fileName, out string json, out ToDo[] items)
        {
            json = File.ReadAllText(fileName);
            items = JsonSerializer.Deserialize<ToDo[]>(json);
            for (int i = 0; i < items.Length; i++)
            {
                string check = "   ";
                if (items[i].IsDone) check = "[x]";
                Console.Write($" {i + 1} {check} {items[i].Title} ");
                Console.WriteLine();
            }
        }
        public static void FillContent(string fileName, out string json, out ToDo[] items)
        {
            items = new ToDo[10];
            items[0] = new ToDo("homework", false);
            items[1] = new ToDo("cleaning", false);
            items[2] = new ToDo("maintenance", false);
            items[3] = new ToDo("shopping", false);
            items[4] = new ToDo("hiking", false);
            items[5] = new ToDo("reading", false);
            items[6] = new ToDo("delivery", false);
            items[7] = new ToDo("shipment", false);
            items[8] = new ToDo("calling customers", false);
            items[9] = new ToDo("reporting", false);
            json = JsonSerializer.Serialize(items);
            File.WriteAllText(fileName, json);
        }

    }
}
