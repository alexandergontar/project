using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson5
{
    public class Demo
    {
        private readonly IBfsDfs _bfsDfs;
        private int _myInt;
        public Demo(IBfsDfs bfsDfs) 
        {
            _bfsDfs = bfsDfs;
        }

        public Demo(int myInt) 
        {
            _myInt = myInt;
        }

        public void DemoBfsDfs() 
        {
            _bfsDfs.BfsDfsDemo();
        }

    }
}
