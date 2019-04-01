using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.Logger
{
    class MyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log with MyLogger. Message : {message}");
        }
    }
}
