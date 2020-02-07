using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        override public double cost()
        {
            return beverage.cost() + .20;
        }
    }
}
