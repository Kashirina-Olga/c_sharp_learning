using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 6, 8);
            Console.WriteLine("Triangle with sides A= {0}, B={1}, C={2}", triangle.A, triangle.B, triangle.C);

            Console.WriteLine("Perimeter= {0}", triangle.getPerimeter());
            Console.WriteLine("Area= {0}", triangle.getArea());
            Console.ReadKey();
        }
    }
}
