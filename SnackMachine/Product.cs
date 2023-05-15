using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }

        public Product(string name, float price, int qty)
        {
            Name = name;
            Price = price;
            Qty = qty;
        }
        public override string ToString()
        {
            return $"name: {Name}, price: {Price}, quantity: {Qty}";
        }
        public bool UpdateStock()
        {
            return false;
        }
    }
}
