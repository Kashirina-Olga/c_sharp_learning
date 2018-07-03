using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }

            Console.WriteLine("Initial array:");
            PrintArray(array);
            Console.Write(Environment.NewLine);
            Console.WriteLine("\nMax array value: {0}", GetMaxValue(array));
            Console.WriteLine("\nMin array value: {0}", GetMinValue(array));

            Console.WriteLine("\nSorted array:");
            int[] newArray = BubbleSort(array);
            PrintArray(newArray);
           
            Console.ReadKey();
        }

        private static int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        private static int GetMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + " ");

            }
        }


        static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

    }
}
