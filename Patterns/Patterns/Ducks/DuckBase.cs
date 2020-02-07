using Patterns.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Fly
{
    public abstract class DuckBase
    {
        public IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }
    
        public void Quack()
        {
            quackBehaviour.Quack();
        }

        public  void Fly()
        {
            flyBehaviour.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
        public abstract void Display();
    }
}