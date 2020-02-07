using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public String getDescription()
        {
            return beverage.getDescription() + ", Steamed Milk";
        }

        override public double cost()
        {
            return beverage.cost() + .10;
        }
    }
}
