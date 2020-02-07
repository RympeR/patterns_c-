using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProxyC
{
    class Class1
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\Георгий Рашков\Desktop\log\log.txt";
            Logging rl = new ProxyLoggingInfo();
            //Logging rl1 = new RealLoggInfo();
            rl.Logg(path);
            //rl1.Logg(path);
            Console.ReadKey();
        }
    }
    interface Logging
    {
        void Logg(String path);
    }
    class RealLoggInfo : Logging
    {
        public void Logg(String path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    string createText = "I'm logging info from baze logg class: " + DateTime.Today.ToString("d") + Environment.NewLine;
                    File.WriteAllText(path, createText);
                }

                string appendText = "I'm logging info from baze logg class: " + DateTime.Today.ToString("d") + Environment.NewLine;
                File.AppendAllText(path, appendText);

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    class ProxyLoggingInfo : Logging
    {
        private RealLoggInfo proxy;
        private List<byte[]> Logs;

        public ProxyLoggingInfo()
        {
            proxy = new RealLoggInfo();
            Logs = new List<byte[]>();
        }

        public void Logg(String path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    string createText = "I'm logging info from proxy logg class: " + DateTime.Now.ToString("f") + Environment.NewLine;
                    File.WriteAllText(path, createText);
                }

                string appendText = "I'm logging info from proxy logg class: " + DateTime.Now.ToString("f") + Environment.NewLine;
                File.AppendAllText(path, appendText);

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
    }
}
