using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTask
{
    class Round
    {
        private double r;
        private double length;
        private double area;

        public double X { get; set; }
        public double Y { get; set; }


        public Round(int x, int y, double r)
        {
            X = x;
            Y = y;
            this.r = r;
        }

        public double GetLength()
        {
            return 2 * Math.PI * r;
        }

        public  double GetArea()
        {
            return Math.PI*r*r;
        }
    }
}
