using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        public delegate bool Rule(string[] array);

        static void Main(string[] args)
        {
            String[] words = {"btrerjei","arereatd" ,"The", "QUICK", "BROWN", "FOX", "jumps",
                         "over", "the", "lazy", "dog"};
            SortArray(words);
            Console.ReadKey();
        }

        static public bool AreEqualLength(string[] array)
        {
            for (int i=0; i < array.Length; i++)
            {
                if (array[0] != array[i]) return false;
            }

            return true;
        }

        static public void SortArray(string[] array)
        {
            Rule rule = new Rule(AreEqualLength);
            if (rule(array))
            {
                LengthComparer comparer = new LengthComparer();
                Array.Sort(array, comparer);
            } else
            {
                AlphabethicComparer alpComparer = new AlphabethicComparer();
                Array.Sort(array, alpComparer);
            }
            
            Console.WriteLine("New array");
            for (int i=0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
