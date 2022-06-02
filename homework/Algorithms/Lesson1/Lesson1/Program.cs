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

        static  Type SelectTypeByName(Type[] types, string name) 
        {
            foreach (Type t in types)
            {
                
                if (t.Name == name)
                {                    
                    return t;
                }

            }
            return null;
        }
  
        static void Main(string[] args)
        {          
            // грузим сборку из файла
            Assembly asm = Assembly.LoadFrom("Lessons.dll");
            Type[] types = asm.GetTypes();
            // сздаем список уроков с единым интерфейсом
            List<ILesson> lessons = new List<ILesson>();
            ILesson l1 = (Lessons.L1.A_Lesson1)Activator.CreateInstance(SelectTypeByName(types, "A_Lesson1"));
            ILesson l2 = (Lessons.L2.B_Lesson2)Activator.CreateInstance(SelectTypeByName(types, "B_Lesson2"));
            ILesson l3 = (Lessons.L3.C_Lesson3)Activator.CreateInstance(SelectTypeByName(types, "C_Lesson3"));
            ILesson l4 = (Lessons.L4.D_Lesson4)Activator.CreateInstance(SelectTypeByName(types, "D_Lesson4"));
            ILesson l5 = (Lessons.L5.E_Lesson5)Activator.CreateInstance(SelectTypeByName(types, "E_Lesson5"));
            lessons.Add(l1);
            lessons.Add(l2);
            lessons.Add(l3);
            lessons.Add(l4);
            lessons.Add(l5);   
            // выбор урока по номеру
            Console.Write("Выберите номер урока (например 5): ");
            int lessonNumber = 1;
            int.TryParse(Console.ReadLine(), out lessonNumber);
            try
            {
              lessons[lessonNumber - 1].RunLesson();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }           
    
        }
    }
}
