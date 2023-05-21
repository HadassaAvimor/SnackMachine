using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Suppliers;

internal class OsemSupplier : Supplier
{
    public OsemSupplier(string name, string email, Dictionary<Product, List<Product>> products) : base(name, email, products)
    {
    }
}

