using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Triangle
    {
        private double length;
        private double p;
        private double h;

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle (double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double getArea()
        {
            p = (A + B + C) / 2;
            h = 2 * Math.Sqrt(p * (p - A) * (p - B) * (p - C))/ A;
            return h;
        }

        public double getPerimeter()
        {
            length = A + B + C;
            return length;
        }

    }
}
