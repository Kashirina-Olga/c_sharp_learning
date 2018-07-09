using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingTask
{
    class Ring : Round
    {

        private double extR;

        public new double X { get; set; }
        public new double Y { get; set; }

        public Ring(int x, int y, double r, double extR) : base(x, y, r)
        {
            X = x;
            Y = y;
            this.r = r;
            this.extR = extR;
        }

        
        public double GetExtLength()
        {
            return 2 * Math.PI * extR;
        }
       

        override
        public double GetArea()
        {
            return Math.PI * (extR*extR - r * r);
        }
    }
}
