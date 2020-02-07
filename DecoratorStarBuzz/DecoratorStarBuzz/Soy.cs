using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        override public double cost()
        {
            return beverage.cost() + .15;
        }
    }
}
