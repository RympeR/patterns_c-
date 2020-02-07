using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Quack
{
   public class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
