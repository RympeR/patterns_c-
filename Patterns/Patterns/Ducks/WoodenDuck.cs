using Patterns.Fly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Quack
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi. I'm a wooden duck");
        }


    }
}
