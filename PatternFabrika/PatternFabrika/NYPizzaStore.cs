using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFabrika
{
   public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            if (item == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (item == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            else if (item == "clam")
            {
                return new NYStyleClamPizza();
            }
            else if (item == "pepperoni")
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }
}
