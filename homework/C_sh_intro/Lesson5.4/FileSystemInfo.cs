using System;
using System.IO;

namespace Lesson5._4
{
    public static class FileSystemInfo
    {
        public static void GetTree(string path, string root, ref string content)
        {
            if (path == root)
            {
                return;
            }
            if (Directory.GetParent(path) != null)
            {
                path = Directory.GetParent(path).ToString();
                Console.WriteLine(path);
                content += path + "\n";
                GetTree(path, root, ref content);
            }
        }

        public static void GetEntries(string currDir, ref string content)
        {
            string[] entries = Directory.GetFileSystemEntries(currDir,
          "*", SearchOption.AllDirectories);
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
                content += entries[i] + "\n";
            }
        }
    }
}
