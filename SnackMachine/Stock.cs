using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.Suppliers;
using System.Collections.Generic;

namespace SnackMachine;

public class Stock
{
    public Dictionary<Snack, List<Product>> Snacks { get; }
    public Dictionary<ColdDrink, List<Product>> ColdDrinks { get; }
    public Dictionary<HotDrink, List<Product>> HotDrinks { get; }



    //פונקציה שמקבלת סטרינג או אינם ומחזירה את המוצר
    //תעדכן את הספקים
    public Stock()
    {
        Snacks = new();
        ColdDrinks = new();
        HotDrinks = new();


        Dictionary<Product, List<Product>> osemProducts = new();
        OsemSupplier giora = new("Giora Har - Zahav", "giora@kibbutz.cat", osemProducts);
        giora.AddProductToMachine(new Snack("ביסלי", 4.90), 7);
        giora.AddProductToMachine(new Snack("במבה", 3.90), 10);
        giora.AddProductToMachine(new ColdDrink("לימונדה", 8), 2);

        Dictionary<Product, List<Product>> cocaColaProducts = new();
        OmerBarLevSupplier yoram = new("Yoram Nishri", "yoram@crazy.com", cocaColaProducts);
        yoram.AddProductToMachine(new ColdDrink("פאנטה", 9), 17);
        yoram.AddProductToMachine(new ColdDrink("קוקה קולה", 9), 22);

        Dictionary<Product, List<Product>> angelProducts = new();
        OmerBarLevSupplier omer = new("Omer Bar Lev", "director@angel.monkey", angelProducts);
        omer.AddProductToMachine(new HotDrink("קפוצ'ינו", 10), 100);
        omer.AddProductToMachine(new HotDrink("שוקו פרלינים", 24), 5);
        omer.AddProductToMachine(new HotDrink("תה חמדת השקד", 6), 1);


        List<Supplier> suppliers = new()
        {
            giora,
            yoram,
            omer
        };


        foreach (var supplier in suppliers)
        {
            Dictionary<Product, List<Product>> products = supplier.Products;

            foreach (KeyValuePair<Product, List<Product>> kvp in products)
            {

                if (kvp.Key is Snack)
                {
                    Snacks.Add((Snack)kvp.Key, kvp.Value);
                }
                else if (kvp.Key is ColdDrink)
                {
                    ColdDrinks.Add((ColdDrink)kvp.Key, kvp.Value);
                }
                else if (kvp.Key is HotDrink)
                {
                    HotDrinks.Add((HotDrink)kvp.Key, kvp.Value);
                }
            };
        }
    }

    public Product GetProduct(string productName)
    {
        foreach (KeyValuePair<Snack, List<Product>> kvp in Snacks)
        {
            if (kvp.Key.Equals(productName))
            {
                Product? snack = kvp.Value.FirstOrDefault();
                //null?
                //מלאי אזל
                 
                return snack;
            }
        }
        //מלאי אזל
        return new Snack("njn", 3);
    }

    public void DeleteProduct(Product product)
    {

        foreach (KeyValuePair<Snack, List<Product>> kvp in Snacks)
        {
            if (kvp.Key.Equals(product.Name))
            {
                Product? snack = kvp.Value.FirstOrDefault();
                Snacks.Remove((Snack)snack);
            }
        }

        foreach (KeyValuePair<ColdDrink, List<Product>> kvp in ColdDrinks)
        {
            if (kvp.Key.Equals(product.Name))
            {
                Product? coldDrink = kvp.Value.FirstOrDefault();
                ColdDrinks.Remove((ColdDrink)coldDrink);
            }
        }
        foreach (KeyValuePair<HotDrink, List<Product>> kvp in HotDrinks)
        {
            if (kvp.Key.Equals(product.Name))
            {
                Product? hotDrink = kvp.Value.FirstOrDefault();
                HotDrinks.Remove((HotDrink)hotDrink);
            }
        }
    }
}