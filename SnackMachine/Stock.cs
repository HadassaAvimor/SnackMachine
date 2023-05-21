using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.Suppliers;
using System.Collections.Generic;

namespace SnackMachine;

public class Stock
{
    const int NUMFORORDERS = 10;
    public Dictionary<string, List<Product>> Snacks { get; }
    public Dictionary<string, List<Product>> ColdDrinks { get; }
    public Dictionary<string, List<Product>> HotDrinks { get; }

    public Dictionary<string, Supplier> ProductsSuppliers { get; }


    //פונקציה שמקבלת סטרינג או אינם ומחזירה את המוצר
    //תעדכן את הספקים
    public Stock(Dictionary<string, List<Product>> snacks, Dictionary<string, 
        List<Product>> coldDrink, Dictionary<string, List<Product>> hotDrink, Dictionary<string, Supplier> productsSuppliers)
    {
        Snacks = snacks;
        ColdDrinks = coldDrink; 
        HotDrinks = hotDrink; 
        ProductsSuppliers = productsSuppliers;
        //Dictionary<Product, List<Product>> osemProducts = new();
        //OsemSupplier giora = new("Giora Har - Zahav", "giora@kibbutz.cat", osemProducts);
        //giora.AddProductToMachine(new Snack("ביסלי", 4.90), 7);
        //giora.AddProductToMachine(new Snack("במבה", 3.90), 10);
        //giora.AddProductToMachine(new ColdDrink("לימונדה", 8), 2);

        //Dictionary<Product, List<Product>> cocaColaProducts = new();
        //OmerBarLevSupplier yoram = new("Yoram Nishri", "yoram@crazy.com", cocaColaProducts);
        //yoram.AddProductToMachine(new ColdDrink("פאנטה", 9), 17);
        //yoram.AddProductToMachine(new ColdDrink("קוקה קולה", 9), 22);

        //Dictionary<Product, List<Product>> angelProducts = new();
        //OmerBarLevSupplier omer = new("Omer Bar Lev", "director@angel.monkey", angelProducts);
        //omer.AddProductToMachine(new HotDrink("קפוצ'ינו", 10), 100);
        //omer.AddProductToMachine(new HotDrink("שוקו פרלינים", 24), 5);
        //omer.AddProductToMachine(new HotDrink("תה חמדת השקד", 6), 1);


        //List<Supplier> suppliers = new()
        //{
        //    giora,
        //    yoram,
        //    omer
        //};


        //foreach (var supplier in suppliers)
        //{
        //    Dictionary<Product, List<Product>> products = supplier.Products;

        //    foreach (KeyValuePair<Product, List<Product>> kvp in products)
        //    {

        //        if (kvp.Key is Snack)
        //        {
        //            Snacks.Add((Snack)kvp.Key, kvp.Value);
        //        }
        //        else if (kvp.Key is ColdDrink)
        //        {
        //            ColdDrinks.Add((ColdDrink)kvp.Key, kvp.Value);
        //        }
        //        else if (kvp.Key is HotDrink)
        //        {
        //            HotDrinks.Add((HotDrink)kvp.Key, kvp.Value);
        //        }
        //    };
        //}
    }

    public Product GetSnacksProduct(string productName)
    {
        if (Snacks.ContainsKey(productName))
        {
            if (Snacks[productName].Count == 5)
            {
                ProductsSuppliers[productName].OrderProduct(productName, NUMFORORDERS);
            }
            if (Snacks[productName].Count == 0)
            {
                return null;
            }
            Product product = Snacks[productName][0];
            Snacks[productName].Remove(product);
            return product;
        }
        return null;
    }

    public Product GetColdDrinksProduct(string productName)
    {
        if (ColdDrinks.ContainsKey(productName))
        {
            if (ColdDrinks[productName].Count == 5)
            {
                ProductsSuppliers[productName].OrderProduct(productName, NUMFORORDERS);
            }
            if (ColdDrinks[productName].Count == 0)
            {
                return null;
            }
            Product product = ColdDrinks[productName][0];
            ColdDrinks[productName].Remove(product);
            return product;
        }
        return null;
    }
    public Product GetHotDrinksProduct(string productName)
    {
        if (HotDrinks.ContainsKey(productName))
        {
            if (HotDrinks[productName].Count == 5)
            {
                ProductsSuppliers[productName].OrderProduct(productName, NUMFORORDERS);
            }
            if (HotDrinks[productName].Count == 0)
            {
                return null;
            }
            Product product = HotDrinks[productName][0];
            HotDrinks[productName].Remove(product);
            return product;
        }
        return null;
        //מלאי אזל
    }
}