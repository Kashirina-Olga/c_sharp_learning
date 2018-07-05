using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageWordLengthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any stroke: ");
            string stroke = Console.ReadLine();
            Console.WriteLine("Average Length: {0}", GetAverageLength(stroke));
            Console.ReadKey();
        }

        static double GetAverageLength(string inputString)
        {
            int averageLength = 0;
            char[] charsToTrim = { ',', ' ' };
            string[] stringArray = inputString.Split(charsToTrim);
            foreach (string val in stringArray)
            {
                averageLength += val.Length;
            }
            averageLength /= stringArray.Length;
            return averageLength;
        }
    }
}
