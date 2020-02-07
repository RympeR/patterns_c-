using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablonIntegral
{
    class Trapezia : ShablIntegr
    {
        public Trapezia(double h, double a, double b, double step)
        {
            this.h = h;
            this.a = a;
            this.b = b;
            this.step = step;
        }
        public override double calc(double x, double y)
        {
            return (x+y) / 2;
        }
        public override double Diff(double a, double b)
        {
            return this.b - this.a;
        }
    }
}
