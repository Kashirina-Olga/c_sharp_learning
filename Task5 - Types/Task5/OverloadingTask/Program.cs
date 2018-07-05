using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString myString1 = new MyString("234");
            MyString myString2 = new MyString("45");

            Console.WriteLine("Add objects ");

            myString1 = myString1 + myString2;

            Console.WriteLine(myString1);
            Console.ReadKey();

        }
    }
}
