using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.HotDrinks
{
    public class HotDrink : Product
    {

        public HotDrink(string name, double price) : base(name, price)
        {
        }

        //enum?
        public double Powder { get; set; }
        public double Suger { get; set; } // teaspoon
        public int Water { get; set; } // ml
        public int Milk { get; set; } // ml
    }
}
