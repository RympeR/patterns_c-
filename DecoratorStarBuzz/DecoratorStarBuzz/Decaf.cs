using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        override public double cost()
        {
            return 1.05;
        }
    }
}
