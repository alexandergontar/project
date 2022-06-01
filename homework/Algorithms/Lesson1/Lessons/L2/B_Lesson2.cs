using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L2
{
    public class B_Lesson2 : ILesson
    {
        public void RunLesson()
        {            
            LinkedListRun lr = new LinkedListRun();
            ElementSearch es = new ElementSearch();
            lr.CheckList();
            es.RunBinarySearch();
        }

      
    }
}
