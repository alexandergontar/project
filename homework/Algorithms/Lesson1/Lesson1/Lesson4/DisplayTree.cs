using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Lesson4
{
    public class DisplayTree
    {
        static readonly int COUNT = 10;
        public class TNode
        {
            public int Value;
            public TNode LeftChild, RightChild;

            /// <summary>
            /// Конструктор
            /// </summary>
            /// <param name="value">Целое значение</param>
            public TNode(int value)
            {
                this.Value = value;
                this.LeftChild = null;
                this.RightChild = null;
            }
        };

        /// <summary>
        /// Распечатывает дерево слева на право
        /// </summary>
        /// <param name="root">Корневой элемент</param>
        /// <param name="space">Промежуток</param>
        static void PrintTree(TNode root, int space)
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

        // Обертка 
        static void DispTree(TNode root)
        {
            // Изначальный промежуток 0
            PrintTree(root, 0);
        }
        /// <summary>
        /// Вставка
        /// </summary>
        /// <param name="root">корень</param>
        /// <param name="v">значение</param>
        /// <returns>Узел</returns>
        static TNode Insert(TNode root, int v)
        {
            if (root == null)
            {
                root = new TNode(v);
            }
            else if (v < root.Value)
            {
                root.LeftChild = Insert(root.LeftChild, v);
            }
            else
            {
                root.RightChild = Insert(root.RightChild, v);
            }

            return root;
        }

        /// <summary>
        /// Поиск по значению
        /// </summary>
        /// <param name="value">значение</param>
        /// <param name="parent">корневой узел</param>
        /// <returns>искомый узел</returns>
        static TNode Find(int value, TNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Value) return parent;
                if (value < parent.Value)
                    return Find(value, parent.LeftChild);
                else
                    return Find(value, parent.RightChild);
            }

            return null;
        }

        static TNode Remove(TNode parent, int value)
        {
            if (parent == null) return parent;

            if (value < parent.Value) parent.LeftChild = Remove(parent.LeftChild, value);
            else if (value > parent.Value)
                parent.RightChild = Remove(parent.RightChild, value);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftChild == null)
                    return parent.RightChild;
                else if (parent.RightChild == null)
                    return parent.LeftChild;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Value = MinValue(parent.RightChild);

                // Delete the inorder successor  
                parent.RightChild = Remove(parent.RightChild, parent.Value);
            }

            return parent;
        }
        static int MinValue(TNode node)
        {
            int minv = node.Value;

            while (node.LeftChild != null)
            {
                minv = node.LeftChild.Value;
                node = node.LeftChild;
            }

            return minv;
        }

        public static void CallTreeMethods() 
        {
            TNode root = new TNode(6);// корень
            // 1 уровень
            root.LeftChild = new TNode(2);
            root.RightChild = new TNode(11);
            // 2 уровень
            root.LeftChild.LeftChild = new TNode(1);
            root.LeftChild.RightChild = new TNode(3);
            root.RightChild.LeftChild = new TNode(9);
            root.RightChild.RightChild = new TNode(30);
            //отображение
            Console.WriteLine("=========Исходное дерево========");
            DispTree(root);
            Console.WriteLine("=========Добавляем 31 ===========");
            Insert(root, 31);
            DispTree(root);
            Console.WriteLine("=========Ищем  30 ===========");
            TNode node = Find(30, root);
            if (node != null)
            {
                Console.WriteLine("Найден: " + node.Value);
            }
            else
            {
                Console.WriteLine("Узел не найден");
            }
            Console.WriteLine("=========Удаляем 31 ===========");
            Remove(root, 31);
            DispTree(root);
            Console.ReadKey();
        }
    }
}
