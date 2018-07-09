using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingTask
{
    class Round
    {
        protected double r;
        private double length;
        private double area;

        protected double X { get; set; }
        protected double Y { get; set; }

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


        public virtual double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
