using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mvc
{
    class GFG : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.CompareTo(y);

        }
    }

    public class Controller
    {
        Model m = new Model();
        GFG g = new GFG();
        public Controller(Model m)
        {
            this.m = m;
        }
        
        public void ADD(string item)
        {
            m.Add(item);
            m.NotifyObservers();
            
        }
        public void REMOVE(string item)
        {
            m.remove(item);
            m.NotifyObservers();
        }

        public void Sort()
        {
            List<String> a = this.m.getList();
            a.Sort(this.g);
            m.setList(a);
            m.NotifyObservers();
        }
        

      
    }
}
