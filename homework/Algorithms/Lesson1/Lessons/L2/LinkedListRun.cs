using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.L2
{
    public class LinkedListRun
    {
        public  void CheckList()
        {
            // создаем список из 3-х элементов
            Console.WriteLine("Создаем список из 3-х элементов с значениями 1, 2 и 3");
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };

            node1.NextNode = node2;
            node2.PrevNode = node1;
            node2.NextNode = node3;
            node3.PrevNode = node2;

            Console.WriteLine("Применяем реализованные методы для данного ILinkedList");
            ILinkedList inter = new LinkedListImplement();
            int count = inter.GetCount(node1);
            Console.WriteLine("Начальное число элементов: " + count);
            inter.AddNodeAfter(node2, 10);
            Console.WriteLine("Применяем AddNodeAfter(node2, 10)");
            count = inter.GetCount(node1);
            Console.WriteLine("Новое число элементов: " + count);
            Console.WriteLine("Значение нового элемента: " + node2.NextNode.Value);
            inter.AddNode(node1, 30);
            Console.WriteLine("Применяем AddNode(node1, 30)");
            count = inter.GetCount(node1);
            Console.WriteLine("Текущее число элементов: " + count);
            inter.RemoveNode(node2);
            Console.WriteLine("Применяем RemoveNode(node2)");
            count = inter.GetCount(node1);
            Console.WriteLine("Текущее число элементов: " + count);
            if (inter.FindNode(node2, 30) != null)
            {
                Console.WriteLine("Поиск элемента по значению: FindNode(node2, 30)");
                Console.WriteLine("Вывод значения: " + inter.FindNode(node2, 30).Value);
            }
            inter.RemoveNode(node1, 2);
            Console.WriteLine("Удаляем элемент по его значению- RemoveNode(node1, 2)");
            count = inter.GetCount(node1);
            Console.WriteLine("Текущее число элементов: " + count);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
