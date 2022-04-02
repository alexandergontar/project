using System;
using System.IO;
/*
 get current dir entries path tree by loop and recursion
 */
namespace Lesson5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "tree.txt";
            string content = String.Empty;
            string currDir = Environment.CurrentDirectory;
            string root = currDir.Substring(0, 3); // e.g "C:\" or "D:\"
            Console.WriteLine("--Запись в файл: " + filename);
            FileSystemInfo.GetEntries(currDir, ref content); //get current dir enrties
            Console.WriteLine(currDir);
            content += currDir + "\n";
            while (currDir != root) //get tree by loop
            {
                try
                {
                    if (Directory.GetParent(currDir) != null)
                    {
                        currDir = Directory.GetParent(currDir).ToString();
                        Console.WriteLine(currDir);
                        content += currDir + "\n";
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("End");
                }
            }
            File.WriteAllText(filename, content);
            filename = "recurtree.txt";
            content = String.Empty;
            currDir = Environment.CurrentDirectory;
            Console.WriteLine("Теперь путем рекурсии, нажмите любую клавишу:");
            Console.ReadKey();
            Console.WriteLine("--Запись в файл: " + filename);
            FileSystemInfo.GetEntries(currDir, ref content); // get current dir entries
            Console.WriteLine(currDir);
            content += currDir + "\n";
            FileSystemInfo.GetTree(currDir, root, ref content); // get tree by recursive method
            File.WriteAllText(filename, content);
            Console.ReadKey();
        }
    }
}
