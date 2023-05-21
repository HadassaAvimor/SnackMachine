using SnackMachine.Report;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        //כפתור הפעלה שמפעיל את המכונה????
        public Machine machine { get; set; }
        Product product { get; set; }
        //public IState State { get; set; }
        //public Context context { get; set; }
        public Form1()
        {
            InitializeComponent();
            Stock stock = new Stock();
            machine = new Machine(stock);

        }

        private void snackBtn_Click_1(object sender, EventArgs e)
        {
            machine.Context.ChangeMode(machine.SnackPurchaseMode);
            machine.Context.State.ButtonsHandler(product);
        }

        private void coldDrinkBtn_Click(object sender, EventArgs e)
        {
            machine.Context.ChangeMode(machine.ColdDrinkPurchaseMode);
            machine.Context.State.ButtonsHandler(product);
        }

        private void hotDrinkBtn_Click(object sender, EventArgs e)
        {
            machine.Context.ChangeMode(machine.HotDrinkPurchaseMode);
            machine.Context.State.ButtonsHandler(product);
        }

        private void back_Click(object sender, EventArgs e)
        {
            machine.Context.ChangeMode(machine.InitialMode);
            machine.Context.State.ButtonsHandler(product);
        }
    }
}