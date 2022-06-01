using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lessons.L1
{
    public class A_Lesson1 : ILesson
    {
        
        public void RunLesson() 
        {
       
            PrimeNumberCalc pn = new PrimeNumberCalc();
            FibNumberCalc fn = new FibNumberCalc();
            pn.CheckPrime();
            fn.CalculateFib();
        }
    }
}
