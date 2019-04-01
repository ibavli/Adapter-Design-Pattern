using Adapter_Design_Pattern.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new MyLogger());
            ProductManager productManager = new ProductManager(new Log4NetAdapter());

            productManager.Save();

            Console.ReadKey();
        }
    }  
}
