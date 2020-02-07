using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fly
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Hi. I'm flying with wings");
        }
    }
}
