using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(2, 0, 5, 8);
            double area = ring.GetArea();
            double length = ring.GetLength();
            double extLength = ring.GetExtLength();

            Console.WriteLine("Ring with center ({0};{1})", ring.X, ring.Y);
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("External Length: {0}", extLength);
            Console.ReadKey();
        }
    }
}
