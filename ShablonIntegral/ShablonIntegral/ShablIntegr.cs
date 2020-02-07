using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablonIntegral
{
    abstract class ShablIntegr
    {
        public double h;
        public double a;
        public double b;
        public double step;
        public double res = 0;
        public ShablIntegr(){}
        public double getRes()
        {
            for (double i = 0; i < this.Diff(this.a, this.b); i +=( this.Diff(this.a, this.b) / this.step))
            {
                Console.WriteLine("i " + i + " res " + res);
                this.Set(1/Math.Log10(i));
            }
            return this.res * h;
        }
        public abstract double Diff(double a, double b);
       
        public abstract double calc(double x, double y);  
        protected void Set(double x)
        {
            this.res += x;
        }
        
    }
}
