using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Snacks
{
    public class Snack : Product
    {
        public Snack(string name, double price) : base(name, price)
        {
            Type = ProductType.snack;
        }
    }
}
