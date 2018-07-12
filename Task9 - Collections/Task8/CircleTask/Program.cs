using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count of elements in list: ");
            int elCount = Convert.ToInt16(Console.ReadLine());
            List<int> resultList = RemoveOddNumbers(AddNumbers(elCount));
            Console.ReadKey();
        }

        private static List<int> AddNumbers(int n)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            return list;
        }

        private static List<int> RemoveOddNumbers(List<int> list)
        {
            //while (list.Count != 1)
            //{
            //    PrintList(list);
            //    for (int i = 1; i <= list.Count; i += 2)
            //    {

            //        if (!(list.Count <= 1))
            //        {
            //            if (i != 1)
            //            {
            //                break;
            //            }
            //            list.RemoveAt(i);
            //        }
            //    }
            //}

            //int i = 1;
            //while (list.Count != 1)
            //{
            //    list.RemoveAt(i);
            //    i += 2;
            //    PrintList(list);
            //}

            //while (list.Count() > 1)
            //{
            //    Iterator iterator = list.iterator();
            //    for (int i = 0; iterator.hasNext(); i++, iterator.next())
            //    {
            //        if (i % 2 == 1)
            //        {
            //            i = 0;
            //            iterator.remove();
            //        }
            //    }
            //}

            return list;
        }

        public static void PrintList(List<int> list)
        {
            foreach (int el in list)
            {
                Console.Write(el + " ");
            }
            Console.Write("\n_________________________________________\n");

        }
    }
}
