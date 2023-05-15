using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public abstract class Suppliers : StockListeners
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public abstract void AddProduct();
        
    }
}
