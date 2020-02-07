using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFabrika
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            if (item == "cheese")
            {
                return new CHicagoStyleCheesePizza();
            }
            else if (item == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (item == "clam")
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else
            {
                return null;
            }
        }
    }
}
