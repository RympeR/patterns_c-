using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePattern
{
    public class Singleton
    {

        private static Singleton uniqueInstance = null;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Console.WriteLine(s1.GetHashCode());

            Singleton s2 = Singleton.getInstance();
            Console.WriteLine(s2.GetHashCode());

        }
    }
}
