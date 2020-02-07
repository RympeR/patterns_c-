using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fly
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
           
        }
        public override void Display()
        {
            Console.WriteLine("Hi. I'm a rubber duck!");
        }

    }
}
