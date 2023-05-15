using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.ColdDrinks
{
    public class ColdDrink : Product
    {
        public ColdDrink(string name, double price, int amount) : base(name, price, amount)
        {
        }
    }
}
