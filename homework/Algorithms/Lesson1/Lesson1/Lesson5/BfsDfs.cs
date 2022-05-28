using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson5
{
   public class BfsDfs : IBfsDfs
    {
        readonly int COUNT = 10; 

        private void PrintTree(TreeNode root, int space)
        {
            // Base case
            if (root == null)
                return;

            // Увеличить расстояние между уровнями
            space += COUNT;

            // Правый сын сверху
            PrintTree(root.RightChild, space);

            // Текущий узел
            // 

            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Value + "\n");

            // Левый сын снизу
            PrintTree(root.LeftChild, space);
        }

        private void BFS(TreeNode root, int searchValue)
        {
            // поиск вширину, используя очередь
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                Console.WriteLine(node.Value);
                if (node.Value == searchValue)
                {
                    Console.WriteLine(searchValue + " найдено");
                    return;
                }
                if (node.LeftChild != null)
                    queue.Enqueue(node.LeftChild);
                if (node.RightChild != null)
                    queue.Enqueue(node.RightChild);
            }
        }

        private void DFS(TreeNode root, int searchValue)
        {
            // поиск в глубину, используя стек
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                Console.WriteLine(node.Value);
                if (node.Value == searchValue)
                {
                    Console.WriteLine(searchValue + " найдено");
                    return;
                }
                if (node.LeftChild != null)
                    stack.Push(node.LeftChild);
                if (node.RightChild != null)
                    stack.Push(node.RightChild);
            }
        }
        /// <summary>
        /// создание дерева и вызов методов
        /// </summary>
        public void BfsDfsDemo() 
        {
            TreeNode root = new TreeNode();
            root.Value = 6; //root

            TreeNode node2 = new TreeNode();//root left
            node2.Value = 2;
            TreeNode node11 = new TreeNode();// root right
            node11.Value = 11;
            root.LeftChild = node2;
            root.RightChild = node11;
            TreeNode node3 = new TreeNode();// node2 right
            node3.Value = 3;
            node2.RightChild = node3;
            TreeNode node9 = new TreeNode(); // node11 left
            node9.Value = 9;
            TreeNode node30 = new TreeNode(); // node11 right
            node30.Value = 30;
            node11.LeftChild = node9;
            node11.RightChild = node30;            
            Console.WriteLine("==Дерево. Вид слева направо===");
            PrintTree(root, 0);
            Console.WriteLine("==Поиск значения 30 в ширину===");
            BFS(root, 30);
            Console.WriteLine("==Поиск значения 3 в глубину===");
            DFS(root, 3);
            Console.ReadKey();
        }

    }
}
