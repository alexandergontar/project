using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_modified
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "P@ssw0rd";
            Console.WriteLine("Введите пароль:");
            if (!(Console.ReadLine() == str))
                return;
            Console.WriteLine("Welcome!");
        }
    }
}
