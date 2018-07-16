using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class AlphabethicComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (x.CompareTo(y));
        }
    }
}
