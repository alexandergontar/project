using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5._3
{
    public static class ParseNumbers
    {
        public static byte[] ParseBinary(string inputString)
        {
            inputString += " ";
            string temp = String.Empty;
            int count = 0;
            byte[] byteAarray = new byte[100];

            for (int i = 0; i < inputString.Length; i++)
            {
                char c = inputString[i];
                if (Char.IsDigit(c))
                {
                    temp += c;
                }
                else if (temp.Length > 0)
                {
                    int n = Convert.ToInt32(temp);
                    if (n > 255 || n < 0)
                    {
                        Console.WriteLine("Числа должны быть в интервале: 0...255");
                        Console.ReadKey();
                        return new byte[0];
                    }
                    byteAarray[count] = Convert.ToByte(temp);
                    temp = String.Empty;
                    count++;
                }
            }

            byte[] writeBinary = new byte[count];
            for (int i = 0; i < count; i++)
            {
                writeBinary[i] = byteAarray[i];
            }

            return writeBinary;
        }
    }
}
