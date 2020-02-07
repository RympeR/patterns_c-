using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablonIntegral
{
    class Client
    {
        public static void ClientCode(ShablIntegr abstractClass)
        {   
            Console.WriteLine(abstractClass.getRes());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShablIntegr it = new Trapezia(3, 9, 21,4);
            ShablIntegr ir = new Rectangle(3, 9, 21,4);
            Console.WriteLine(it.getRes());
            Console.Write("\n");
            Console.WriteLine(ir.getRes());
            Console.Write("\n");
            ir.res = 0;
            it.res = 0;
            ShablIntegr it1 = new Trapezia(3, 9, 21, 5);
            ShablIntegr ir1 = new Rectangle(3, 9, 21, 5);
            Console.WriteLine(it1.getRes());
            Console.Write("\n");
            Console.WriteLine(ir1.getRes());
            Console.ReadKey();
        }
    }
}
