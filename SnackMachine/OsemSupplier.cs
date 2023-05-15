using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine;

    internal class OsemSupplier : Supplier
    {
        public OsemSupplier(string name, string email, List<Product> products) : base(name, email, products)
        {
        }

        public override void AddProductsToMachine(Machine machine, Product product, int amount)
        {
            if (product is Snack)
            {
                machine.Snacks.Add((Snack)product, product.Amount);
            }
            else if (product is ColdDrink)
            {
                machine.ColdDrinks.Add((ColdDrink)product, product.Amount);
            }
        }
    }

