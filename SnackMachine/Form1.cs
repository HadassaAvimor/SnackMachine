using SnackMachine.Report;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        public Machine Machine { get; set; }

        public Form1(Stock stock)
        {
            InitializeComponent();
            Machine = new Machine(stock);
        }

        private void snackBtn_Click_1(object sender, EventArgs e)
        {
            Machine.Context.ChangeMode(Machine.SnackPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        }

        private void coldDrinkBtn_Click(object sender, EventArgs e)
        {
            Machine.Context.ChangeMode(Machine.ColdDrinkPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        }

        private void hotDrinkBtn_Click(object sender, EventArgs e)
        {
            Machine.Context.ChangeMode(Machine.HotDrinkPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Machine.Context.ChangeMode(Machine.InitialMode);
            Machine.Context.State.ButtonsHandler();
        }
    }
}