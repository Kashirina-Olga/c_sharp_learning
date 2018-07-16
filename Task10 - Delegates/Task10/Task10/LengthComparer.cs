using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class LengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }

        //public int Compare(string x, string y)
        //{
        //    if (x.Length.CompareTo(y.Length) != 0)
        //    {
        //        return x.Length.CompareTo(y.Length);
        //    }
        //    else return (x.CompareTo(y));
        //}


        public bool areEqualLength(string x, string y)
        {
            return x.Length.CompareTo(y.Length) != 0;
        }
    }
}
