using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        override public double cost()
        {
            return beverage.cost() + .10;
        }
    }
}
