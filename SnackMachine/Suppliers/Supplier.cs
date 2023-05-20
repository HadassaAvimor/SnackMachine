using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Suppliers
{
    public abstract class Supplier : StockListeners
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Dictionary<Product, List<Product>> Products { get; set; }

        public void AddProduct(Product product, int amount)
        {
            List<Product> products = new List<Product>();
            for(int i = 0; i < amount; i++)
            {
                products.Add(new Product(product.Name, product.Price));
            }
        }
        public abstract void AddProductsToMachine(Machine machine, Product product, int amount);

        public Supplier(string name, string email, List<Product> products)
        {
            Name = name;
            Email = email;
            Products = products;
        }

    }
}
