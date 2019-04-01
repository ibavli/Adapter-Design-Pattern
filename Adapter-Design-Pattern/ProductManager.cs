using Adapter_Design_Pattern.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    public class ProductManager
    {
        private readonly ILogger _logger;

        public ProductManager(ILogger logger)
        {
            this._logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }
}
