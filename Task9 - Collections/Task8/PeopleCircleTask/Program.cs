using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCircleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = AddNumbers(10);
            Display(list, "Original list");
            GoOnList(list);

            Console.ReadKey();
        }

        private static LinkedList<int> AddNumbers(int n)
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 1; i <= n; i++)
            {
                list.AddLast(i);
            }
            return list;
        }


        private static void Display(LinkedList<int> words, string test)
        {
            Console.WriteLine(test);
            foreach (int word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // возвращаемся к первому элементу
        private static LinkedListNode<int> ReturnToFirst(LinkedListNode<int> node)
        {
            LinkedList<int> list = node.List;
            LinkedListNode<int> nodeRes = null;


            if (node.Next == null)
            {
                nodeRes = node.List.First.Next;
                list.Remove(node.Previous.Value);
            }
            else if (node.Next.Next == null)
            {
                LinkedListNode<int> temp = node.List.First;
                list.Remove(node.Next.Value);
                nodeRes = temp;
            }

            else
            {
                nodeRes = node.Next.Next;
                list.Remove(nodeRes.Previous.Value);
            }

            return nodeRes;
        }

        private static LinkedList<int> GoOnList(LinkedList<int> list)
        {
            LinkedListNode<int> node = list.First;
            while (list.Count > 2)
            {

                node = ReturnToFirst(node);
                Display(list, "Temporary result");

            }
            return list;
        }

    }
}
