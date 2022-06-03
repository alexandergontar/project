using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L7
{
    public class G_Lesson7 : ILesson
    {
        public void RunLesson()
        {
            Console.WriteLine("===== Задача о 8 ферзях ======");
            Console.WriteLine("Демонстрация расстановки ферзей по столбщам доски a b c d e f g h");
            Console.WriteLine("Цмфры в каждом варианте означают номер строкм в столбце.");
            F8 f8 = new F8();
            f8.F8_Run();            
        }
    }
}
