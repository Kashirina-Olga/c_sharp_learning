using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPositiveSumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            Console.WriteLine("Initial array:");
            PrintArray(array);

            int sum = SumNotNegativeElements(array);
            Console.WriteLine("\nSum: {0}", sum);

            Console.ReadKey();
        }

        private static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + " ");

            }
        }

        private static int SumNotNegativeElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
