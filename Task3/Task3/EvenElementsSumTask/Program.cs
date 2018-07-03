using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenElementsSumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = 8;
            int m = 8;
            int[,] array = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = random.Next(-10, 50);
                }
            }

            Console.WriteLine("Initial array:");
            PrintArray(array,n,m);

            Console.WriteLine("\nSum:{0}", getSumEvenPositionsElements(array,n,m));

            Console.ReadKey();
        }

        private static void PrintArray(int[,] array,int n,int m)
        {
            for (int i=0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i,j] +" ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        private static int getSumEvenPositionsElements(int[,] array, int n, int m)
        {
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((n + m) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }


    }
}
