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