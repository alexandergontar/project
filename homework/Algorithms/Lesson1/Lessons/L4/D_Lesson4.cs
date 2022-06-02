using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L4
{
    public class D_Lesson4 : ILesson
    {
        public void RunLesson()
        {
            
            DisplayTree dt = new DisplayTree();
            HashSetSearch hsch = new HashSetSearch();
            dt.CallTreeMethods();
            hsch.CallSearchString();
            
        }
    }
}
