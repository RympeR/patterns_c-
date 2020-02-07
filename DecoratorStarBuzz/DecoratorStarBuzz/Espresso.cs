using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        override public double cost()
        {
            return 1.99;
        }
    }
}
