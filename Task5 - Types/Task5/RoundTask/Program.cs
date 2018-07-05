using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round(2, 0, 5);
            double area = round.GetArea();
            double length = round.GetLength();

            Console.WriteLine("Round with center ({0};{1})", round.X, round.Y);
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine("Length: {0}", length);

            Console.ReadKey();
        }
    }
}
