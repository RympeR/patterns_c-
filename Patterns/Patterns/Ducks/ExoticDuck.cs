using Patterns.Fly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Quack
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuak();
            flyBehaviour = new ExoticFly();
        }
        public override void Display()
        {
            Console.WriteLine("Hi. I'm an exotic duck");
        }

    }
}
