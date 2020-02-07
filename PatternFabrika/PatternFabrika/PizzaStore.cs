using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFabrika
{
    public abstract class PizzaStore
    {
        public abstract Pizza createPizza(String item);

        public Pizza orderPizza(String type)
        {
            Pizza pizza = createPizza(type);
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
