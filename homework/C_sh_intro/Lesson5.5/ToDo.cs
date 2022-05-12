using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._5
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDo()
        {
            //parameterless constructor
        }
        public ToDo(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }
    }
}
