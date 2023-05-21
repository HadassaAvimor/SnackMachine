using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.Suppliers;

namespace SnackMachine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            List<Product> beasley = new();
            for (int i = 0; i < 10; i++)
            {
                Snack s = new Snack("ביסלי", 4.90);
                beasley.Add(s);
            }
            List<Product> bamba = new();
            for (int i = 0; i < 10; i++)
            {
                Snack s = new Snack("במבה", 5);
                bamba.Add(s);
            }

            List<Product> cappucino = new();
            for (int i = 0; i < 10; i++)
            {
                HotDrink c = new("קפוצ'ינו", 10);
                cappucino.Add(c);
            }

            List<Product> coco = new();
            for (int i = 0; i < 7; i++)
            {
                HotDrink c = new("שוקו פרלינים", 16);
                coco.Add(c);
            }

            List<Product> cocaCola = new();
            for (int i = 0; i < 3; i++)
            {
                ColdDrink c = new("קוקה קולה", 16);
                cocaCola.Add(c);
            }

            List<Product> fanta = new();
            for (int i = 0; i < 1; i++)
            {
                ColdDrink c = new("פאנטה", 5);
                fanta.Add(c);
            }
            Dictionary<string, List<Product>> snacks = new();
            snacks.Add("bamba", bamba);
            snacks.Add("beasley", beasley);


            Dictionary<string, List<Product>> coldDrinks = new();
            coldDrinks.Add("cocaCola", cocaCola);
            coldDrinks.Add("fanta", fanta);


            Dictionary<string, List<Product>> hotDrinks = new();
            hotDrinks.Add("cappucino", cappucino);
            hotDrinks.Add("coco", coco);


            Dictionary<string, Supplier> productsSuppliers = new();
            OmerBarLevSupplier omer = new("Omer Bar Lev", "director@angel.monkey");
            OsemSupplier giora = new("Giora Har - Zahav", "giora@kibbutz.cat");

            productsSuppliers.Add("fanta", omer);
            productsSuppliers.Add("cocaCola", giora);
            productsSuppliers.Add("coco", giora);
            productsSuppliers.Add("cappucino", giora);
            productsSuppliers.Add("beasley", omer);
            productsSuppliers.Add("bamba", omer);

            Stock stock = new Stock(snacks, coldDrinks, hotDrinks, productsSuppliers);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(stock));
        }
    }
}