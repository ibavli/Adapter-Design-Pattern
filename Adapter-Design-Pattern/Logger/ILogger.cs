using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.Logger
{
    public interface ILogger
    {
        void Log(string message);
    }
}
