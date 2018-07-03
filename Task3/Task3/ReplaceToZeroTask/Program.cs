using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceToZeroTask
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

            ReplaceToZero(array);
           

            Console.WriteLine("\nReplaced array:");
            PrintArray(array);

            Console.ReadKey();
        }

        private static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + " ");

            }
        }

        private static void ReplaceToZero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = 0;
                }
            }
            
        }
    }
}
