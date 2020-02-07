using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Quack
{
    public class ExoticQuak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!x3");
        }
    }
}
