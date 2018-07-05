using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCharsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleChars();
        }

        private static void DoubleChars()
        {
            Console.WriteLine("Input first string: ");
            string firstString = Console.ReadLine();
            Console.WriteLine("Input second string: ");
            string secondString = Console.ReadLine();

            char[] firstStringCharArray = GetSimbols(firstString);
            char[] secondStringCharArray = GetSimbols(secondString);

            List<char> list = new List<char>();

            for (int j = 0; j < firstStringCharArray.Length; j++)
            {

                if (firstStringCharArray[j]!=','&& firstStringCharArray[j] != ' ')
                {
                    if (IsContain(firstStringCharArray[j], secondStringCharArray)) {
                        list.Add(firstStringCharArray[j]);
                        list.Add(firstStringCharArray[j]);
                    }
                    else
                    {
                        list.Add(firstStringCharArray[j]);
                    }
                } 
            }

            

            string result = string.Join(null, list);

            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }

        private static char[] GetSimbols(String str)
        {
            return str.ToCharArray();
        }

        private static bool IsContain(char ch, char[] array)
        {
           return array.Contains(ch);
        }
    }
}
