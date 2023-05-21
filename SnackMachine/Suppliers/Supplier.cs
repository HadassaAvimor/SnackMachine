using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Suppliers;

public abstract class Supplier : StockListeners
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Dictionary<Product, List<Product>> Products { get; set; }

    public Supplier(string name, string email, Dictionary<Product, List<Product>> products)
    {
        Name = name;
        Email = email;
        Products = products;
    }
    public void AddProductToMachine(Product product, int amount)
    {
        List<Product> products = new List<Product>();

        for (int i = 0; i < amount; i++)
        {
            if(product.Type == ProductType.snack)
            {
                products.Add(new Snack(product.Name, product.Price));
            }
            else if (product.Type == ProductType.coldDrink)
            {
                products.Add(new ColdDrink(product.Name, product.Price));
            }
            else if (product.Type == ProductType.hotDrink)
            {
                products.Add(new HotDrink(product.Name, product.Price));
            }
        }
        Products.Add(product, products);
    }

}
