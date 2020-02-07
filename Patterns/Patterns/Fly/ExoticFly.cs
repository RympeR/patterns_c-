using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fly
{
    public class ExoticFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I fly really exotic");
        }
    }
}
