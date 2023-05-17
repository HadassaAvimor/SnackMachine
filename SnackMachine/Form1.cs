using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void hotDrinkBtn_Click(object sender, EventArgs e)
        {
            PurchaseMode purchaseMode = new();
            purchaseMode.ClickHotDrinkBtn();
        }
    }
}