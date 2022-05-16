using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson2
{
    public class LinkedListImplement : ILinkedList
    {
        public int GetCount(Node firstNode)
        {
            int count = 0;
            while (firstNode != null)
            {
                // Console.WriteLine(firstNode.Value);
                firstNode = firstNode.NextNode;
                count++;
            }
            //Console.WriteLine(count);
            return count;
        }
        public void AddNode(Node startNode, int value)
        {
            Node node = startNode;
            while (node.NextNode != null)
            {
                node = node.NextNode;
            }
            Node newNode = new Node { Value = value };
            node.NextNode = newNode;
            newNode.PrevNode = node;

        }
        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node { Value = value };// новый узел
            newNode.PrevNode = node; // ссылка нового на предыдущий
            Node nextNode = node.NextNode; // ссылка на NextNode предыдущего
            node.NextNode = newNode; // у предыдущего меняем NextNode на новый
            newNode.NextNode = nextNode; //переносим NextNode предыдущего на этот
            nextNode.PrevNode = newNode;

        }

        public static void RemoveNextNode(Node node) //удаление следующего

        {
            if (node.NextNode == null)
                return;
            Node nextNode = node.NextNode.NextNode;
            nextNode.PrevNode = node;
            node.NextNode = nextNode;
        }

        public void RemoveNode(Node startNode, int index)
        {
            if (index == 0)
            {
                Node newStartNode = startNode.NextNode;
                newStartNode.PrevNode = null;
                startNode.NextNode = null;
                return;
            }
            int currentIndex = 0;
            Node currentNode = startNode;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    RemoveNextNode(currentNode);
                    return;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

        }
        public void RemoveNode(Node node)
        {
            Node prevNode;
            Node nextNode;
            if (node == null) return;
            if (node.PrevNode == null && node.NextNode == null)
            {

                return;
            }
            if (node.NextNode == null)
            {
                prevNode = node.PrevNode;
                prevNode.NextNode = null;

                return;
            }
            if (node.PrevNode == null)
            {
                nextNode = node.NextNode;
                nextNode.PrevNode = null;

                return;
            }
            prevNode = node.PrevNode;
            nextNode = node.NextNode;
            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;

        }

        public Node FindNode(Node startNode, int searchValue)
        {
            if (startNode == null)
            {
                Console.WriteLine("Start node is null");
                return null;
            }
            Node currentNode = startNode;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                    return currentNode;
                currentNode = currentNode.NextNode;
            }
            return null;
        }
    }
}
