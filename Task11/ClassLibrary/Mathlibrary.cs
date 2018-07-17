using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mathlibrary
    {
        public static long Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }

        public static long Power(int n, int pow)
        {
            long result = n;
            for (int i=1; i < pow; i++)
            {
                result = result * n;
            }
            return result;
        }
    }
}
