using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mvc
{
    public class Model : ISubject
    {
        List<String> warehouse = new List<String>();
        
        public List<String> getList()
        {
            return this.warehouse;   
        }

        public List<String> setList(List<String> a)
        {
            return this.warehouse = a;
        }
        

        public void remove(String element)
        {
            try
            {
                warehouse.Remove(element);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public void Add(String element)
        {
            warehouse.Add(element);
        }
        private List<IObserver> views = new List<IObserver>();

        public void AddObserver(IObserver o) { views.Add(o); }
        public void RemoveObserver(IObserver o) { views.Remove(o); }
        public void NotifyObservers()
        {
            foreach (IObserver o in views)
                o.Update();
        }
    }
}
