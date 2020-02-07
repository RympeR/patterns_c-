using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarBuzz
{
    public abstract class Beverage
    {
        public String description = "Beverage";

        public String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}
