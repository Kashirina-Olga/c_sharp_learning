using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDynamicArray<int> arr = new MyDynamicArray<int>();
            //arr.Insert(2, 5);
            arr.Add(7);
            arr.Add(9);
            arr.Add(14);
            arr.Add(9);
            arr.Add(14);
            int[] intar = { 4, 3, 2, 4, 2 };
            arr.AddRange(intar);
            //arr.Remove(3);
        }
    }
}
