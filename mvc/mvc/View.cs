using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mvc
{
    public abstract class StoreView : IObserver
    {
        protected Model storeModel;
        protected Controller storeController;
        public StoreView(Model m_, Controller c_)
        {
            storeModel = m_;
            storeModel.AddObserver(this);
            storeController = c_;
        }
        public void SetController(Controller c_)
        {storeController = c_;}
        public abstract void Update();
    }
    public class View : StoreView, IObserver
    {
        public View(Model m_, Controller c_) : base(m_, c_) { }
        public override void Update()
        {
            DisplayStore(storeModel.getList());
        }
        public void DisplayStore(List<String> store)
        {
            Console.Clear();
            Console.WriteLine("Menu:" +
                              "1. add element\n" +
                              "2. remove element\n" +
                              "3. sort\n" + 
                              "4. exit\n"
                              );
            Console.WriteLine("our store");
            for (int i = 0; i < store.Count; i++)
            {
                Console.WriteLine(store[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("What do you want to do?");

        }

        public String getCommand()
        {
            
            string choice = Console.ReadLine();
            return choice;
        }
        public String GetElement()
        {
            Console.WriteLine("Input your choice: ");
            String choice = Console.ReadLine();
            return choice;
        }
        public void DoAction()
        {
            string a;
            switch (this.getCommand())
            {
                case "1":
                    Console.WriteLine("add element");
                    a = this.GetElement();
                    storeController.ADD(a);

                    break;
                case "2":
                    Console.WriteLine("remove element");
                    a = this.GetElement();
                    storeController.REMOVE(a);
                    break;
                case "3":
                    storeController.Sort();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    this.DoAction();
                    break;
            }
        }
       
    }
}
