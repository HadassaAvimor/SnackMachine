using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Suppliers
{
    internal class AlitSupplier : Supplier
    {
        public AlitSupplier(string name, string email, List<Product> products) : base(name, email, products)
        {
        }

        public override void AddProductsToMachine(Machine machine, Product product, int amount)
        {

        }
    }
}
