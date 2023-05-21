using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Suppliers;

internal class OmerBarLevSupplier : Supplier
{
    public OmerBarLevSupplier(string name, string email) : base(name, email)
    {
    }
    public override void OrderProduct(string productName, int amount)
    {

        ///ordering from my company
    }

}
