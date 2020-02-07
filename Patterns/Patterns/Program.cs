using System;
using Patterns.Fly;
using System.Collections.Generic;
using Patterns.Quack;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }
            Console.WriteLine("------------");
            ducks[3].flyBehaviour = new FlyWithWings();
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

        }
    }
}
