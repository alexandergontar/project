using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L8
{
    public class H_Lesson8 : ILesson
    {
        public void RunLesson()
        {
            Console.WriteLine("===== Сортировка подсчетом ======");
            CountingSorting cs = new CountingSorting();
            cs.Sort();
            Console.ReadKey();
        }
    }
}
