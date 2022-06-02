using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L5
{
    public class E_Lesson5 : ILesson
    {
        public void RunLesson()
        {            
            BfsDfs bfsDfs = new BfsDfs();
            bfsDfs.BfsDfsDemo();         

        }
     }
}
