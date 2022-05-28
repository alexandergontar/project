using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class SubmitLesson
    {
        /// <summary>
        /// интерфейс урока 5
        /// </summary>
        private readonly Lesson5.IBfsDfs _IbfsDfs;
        private int _myInt;
       /// <summary>
       /// конструктор к уроку 5
       /// </summary>
       /// <param name="bfsDfs"></param>
        public SubmitLesson(Lesson5.IBfsDfs bfsDfs)
        {
            _IbfsDfs = bfsDfs;
        }
        public SubmitLesson(int myInt) 
        {
            _myInt = myInt;
        }

        public void DemoBfsDfs()
        {
            _IbfsDfs.BfsDfsDemo();
        }

        public void PrintNumber() 
        {
            Console.WriteLine("My number is "+_myInt);
            Console.ReadKey();
        }
    }
}
