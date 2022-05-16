using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson2
{
    interface ILinkedList
    {
        int GetCount(Node firstNode); // возвращает количество элементов в списке
        void AddNode(Node startNode, int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент

        void RemoveNode(Node startNode, int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(Node startNode, int searchValue); // ищет элемент по его значению
    }
}
