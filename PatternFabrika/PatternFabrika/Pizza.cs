using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFabrika
{
    public abstract class Pizza
    {
        public String name;
        public String dough;
        public String sauce;
        public List<Object> toppings = new List<Object>();

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("   " + toppings.ElementAt(i));
            }
        }

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public String getName()
        {
            return name;
        }

        public String toString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + name + " ----\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");
            for (int i = 0; i < toppings.Count; i++)
            {
                display.Append((String)toppings.ElementAt(i) + "\n");
            }
            return display.ToString();
        }
    }
}
