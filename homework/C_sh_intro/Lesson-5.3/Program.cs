using System;
using System.IO;
namespace Lesson_5._3
    /*
     key board bytes entries save to binary file
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "bytes.bin";            
            Console.Write("Введите целые числа в интервале 0...255, разделенные пробелом: ");
            string inputString = Console.ReadLine();
            byte[] writeBinary = ParseNumbers.ParseBinary(inputString);
            if (writeBinary.Length == 0)
            {
                Console.WriteLine("Ошибка ввода, нажмите любую клавишу для завершения.");
                Console.ReadKey();
                return;
            }
            File.WriteAllBytes(fileName, writeBinary);
            byte[] fromFile = File.ReadAllBytes(fileName);
            Console.WriteLine("Запись произведена, содержимое бинарного файла:");
            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.WriteLine(fromFile[i]);
            }
            Console.ReadKey();
        }
    }
}
