using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form//njhu
    {
        public IState initialState { get; set; }
        public Context context { get; set; }
        public Form1()
        {
            InitializeComponent();

                // Create the initial state
                 initialState = new PurchaseMode();

                // Create the context with the initial state
                 context = new Context(initialState);
        }

        private void snackBtn_Click_1(object sender, EventArgs e)
        {
            context.Request();
            PurchaseMode.HandleButtons("כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה", PurchaseMode.stock.Snacks);
            context.Request();

            //PurchaseMode purchaseMode = new();
            //purchaseMode.ClickSnackBtn();
        }

        private void coldDrinkBtn_Click(object sender, EventArgs e)
        {
            context.Request();
            PurchaseMode.HandleButtons("Hello, Yoram;", PurchaseMode.stock.ColdDrinks);
            context.Request();
            //PurchaseMode purchaseMode = new();
            //purchaseMode.ClickColdDrinkBtn();
        }

        private void hotDrinkBtn_Click(object sender, EventArgs e)
        {
            context.Request();
            PurchaseMode.HandleButtons("פיהוק הוא צעקה שקטה לקפה", PurchaseMode.stock.HotDrinks);
            context.Request();
            //PurchaseMode purchaseMode = new();
            //purchaseMode.ClickHotDrinkBtn();
        }
    }
}