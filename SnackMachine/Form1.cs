using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        //public Dictionary<Snack, int> snacks { get  }
        //public Dictionary<ColdDrink, int> coldDrinks { get; }
        public Form1()
        {
            InitializeComponent();


            //List<Supplier> suppliers = new();
            //suppliers.Add(new OsemSupplier("Giora", "Giora@gmail.com", new List<Product> { new Snack("ביסלי", 4.90, 6), new Snack("במבה", 3.90, 10), new ColdDrink("לימונדה", 8, 2) }));
            //suppliers.Add(new CocaColaSupplier("Yoram", "Yoram@gmail.com", new List<Product> { new ColdDrink("קוקה קולה", 9, 22), new ColdDrink("פאנטה", 9, 17) }));
            //foreach (var item in suppliers)
            //{
            //    item.Products.ForEach((p) =>
            //    {
            //        if (p is Snack)
            //        {
            //            snacks.Add(new Snack(p.Name, p.Price, p.Amount), p.Amount);
            //        }
            //        else if (p is ColdDrink)
            //        {
            //            coldDrinks.Add(new ColdDrink(p.Name, p.Price, p.Amount), p.Amount);
            //        }
            //        //hot drink
            //        //amount- 😫🥱😴😌
            //    });
            //}

            //Machine machine = new(snacks, coldDrinks);

        }

        private void snackBtn_Click_1(object sender, EventArgs e)
        {
            //לבדוק את העסק הזה. סינגלטון אולי, לבדוק איך זה מסתדר עם סטייט
            PurchaseMode purchaseMode = new();
            purchaseMode.ClickSnackBtn();
         
        }

        

        private void coldDrinkBtn_Click(object sender, EventArgs e)
        {
            PurchaseMode purchaseMode = new();
            purchaseMode.ClickColdDrinkBtn();
        }
    }
}