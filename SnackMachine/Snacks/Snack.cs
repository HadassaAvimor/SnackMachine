using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Snacks
{
    public class Snack : Product
    {
        public Snack(string name, double price, int amount) : base(name, price, amount)
        {
        }
    }
}
