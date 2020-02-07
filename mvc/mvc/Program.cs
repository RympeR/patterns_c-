using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            Controller c = new Controller(m);
            View v = new View(m, c);
            m.Add("first");
            m.Add("sec");
            m.Add("third");
            m.Add("five");
            m.Add("six");
            m.AddObserver(v);
            Console.WriteLine("Menu:" +
                              "1. add element\n" +
                              "2. remove element\n" +
                              "3. sort\n"+
                              "4. exit\n"
                              );
            Console.WriteLine("our store");
            for (int i = 0; i < m.getList().Count; i++)
            {
                Console.WriteLine(m.getList()[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("What do you want to do?");
            while (true)
            {
                v.DoAction();
                
            }
            //Console.ReadKey();
        }
    }
}
