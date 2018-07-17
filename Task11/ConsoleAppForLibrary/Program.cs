using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Factorial of {0}:", number);
            Console.WriteLine(ClassLibrary.Mathlibrary.Factorial(number));

            Console.WriteLine("Input power");
            int power = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Power {0} of number {1}:",power, number);
            Console.WriteLine(ClassLibrary.Mathlibrary.Power(number, power));
            Console.ReadKey();
        }
    }
}
