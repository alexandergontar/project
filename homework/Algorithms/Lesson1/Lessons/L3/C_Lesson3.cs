using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L3
{
    public class C_Lesson3 : ILesson
    {
        public void RunLesson()
        {            
            TestDistance td = new TestDistance();
            td.Report(5);
            Console.ReadKey();
        }

    }
}
