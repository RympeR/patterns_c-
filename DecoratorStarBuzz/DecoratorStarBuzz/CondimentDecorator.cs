using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract String getDescription();
    }
}
