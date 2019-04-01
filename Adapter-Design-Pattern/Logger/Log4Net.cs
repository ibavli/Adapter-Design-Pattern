using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.Logger
{
    //Bunu nugetten indirdiğimizi düşünün. Hiçbir şekilde interface implement edemeyiz. Ve mevcut sistemi bozmadan bu sistemi entegre etmemiz lazım.
    //Bu yüzden Log4NetAdapter sınıfını yazacağız.
    public class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log with Log4Net. Message : {message}");
        }
    }
}
