using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fly
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi. I'm a simple duck!");
        }
     
    }
}
