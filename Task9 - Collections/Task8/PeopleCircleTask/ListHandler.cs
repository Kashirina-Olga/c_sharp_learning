using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCircleTask
{
    class ListHandler
    {
        private LinkedList<int> list ;

        //private static LinkedList<int> AddNumbers(int n)
        //{
        //    //LinkedList<int> list = new LinkedList<int>();
        //    for (int i = 1; i <= n; i++)
        //    {
        //        list.AddLast(i);
        //    }
        //    return list;
        //}


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

            if ((node.Next.Next == null) || (node.Next == null))
            {

                if (node.Next == null)
                {
                    node = node.List.First.Next;
                    list.Remove(node.Previous.Value);
                }
                else
                {
                    LinkedListNode<int> temp = node.List.First;
                    list.Remove(node.Value);
                    node = temp;
                }
                Display(list, "Pr");

            }
            else
            {
                node = node.Next.Next;
                list.Remove(node.Previous.Value);
            }

            return node;
        }

        private static LinkedList<int> GoOnList(LinkedList<int> list)
        {
            LinkedListNode<int> node = list.First;
            while (list.Count > 2)
            {
                node = ReturnToFirst(node);
            }
            return list;
        }
    }
}
