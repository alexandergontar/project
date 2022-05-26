using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class SubmitLesson
    {
        private readonly Lesson5.IBfsDfs _bfsDfs;
        private int _myInt;
        public SubmitLesson(Lesson5.IBfsDfs bfsDfs)
        {
            _bfsDfs = bfsDfs;
        }
        public SubmitLesson(int myInt) 
        {
            _myInt = myInt;
        }

        public void DemoBfsDfs()
        {
            _bfsDfs.BfsDfsDemo();
        }

        public void PrintNumber() 
        {
            Console.WriteLine("My number is "+_myInt);
            Console.ReadKey();
        }
    }
}
