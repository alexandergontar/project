using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lessons;
using System.Reflection;


namespace Lesson1
{
    class Program
    {      
  
        static void Main(string[] args)
        {          
            // грузим сборку из файла
            Assembly asm = Assembly.LoadFrom("Lessons.dll");
            Type[] types = asm.GetTypes();
          // сздаем список уроков с единым интерфейсом
            List<ILesson> lessons = new List<ILesson>();
            foreach (Type t in types)
            {
                if (typeof(ILesson).IsAssignableFrom(t) && t.Name != "ILesson")
                {
                    ILesson l = Activator.CreateInstance(t) as ILesson;
                    lessons.Add(l);
                   // Console.WriteLine(t.Name);
                }
            }  
          
 
            // выбор урока по номеру
            Console.Write("Выберите номер урока (например 7): ");
            int lessonNumber = 1;
            int.TryParse(Console.ReadLine(), out lessonNumber);
            int i = lessons.Count - lessonNumber;
            try
            {                
                lessons[i].RunLesson();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }           
    
        }
    }
}
