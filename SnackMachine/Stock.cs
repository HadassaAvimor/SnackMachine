using SnackMachine;
using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;

namespace SnackMachine;

public class Stock
{
    public Dictionary<Snack, int> snacks { get ; }
    public Dictionary<ColdDrink, int> coldDrinks { get; }

    public Stock()
    {
        snacks = new();
        coldDrinks = new();

        List<Supplier> suppliers = new();
        suppliers.Add(new OsemSupplier("Giora", "Giora@gmail.com", new List<Product> { new Snack("ביסלי", 4.90, 6), new Snack("במבה", 3.90, 10), new ColdDrink("לימונדה", 8, 2) }));
        suppliers.Add(new CocaColaSupplier("Yoram", "Yoram@gmail.com", new List<Product> { new ColdDrink("קוקה קולה", 9, 22), new ColdDrink("פאנטה", 9, 17) }));
        foreach (var item in suppliers)
        {
            item.Products.ForEach((p) =>
            {
                if (p is Snack)
                {
                    snacks.Add(new Snack(p.Name, p.Price, p.Amount), p.Amount);
                }
                else if (p is ColdDrink)
                {
                    coldDrinks.Add(new ColdDrink(p.Name, p.Price, p.Amount), p.Amount);
                }
                //hot drink
                //amount- 😫🥱😴😌
            });
        }

        Machine machine = new(snacks, coldDrinks);
    }
}