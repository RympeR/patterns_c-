using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablonIntegral
{
    class Rectangle : ShablIntegr
    {
        public Rectangle(double h, double a, double b, double step)
        {
            this.h = h;
            this.a = a;
            this.b = b;
            this.step = step;
        }
        public override double calc(double x, double y)
        {
            return x;
        }
        public override double Diff(double a, double b)
        {
            return this.b - this.a;
        }
    }
}
