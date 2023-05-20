using SnackMachine.Report;
using SnackMachine.States;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        //כפתור הפעלה שמפעיל את המכונה????
        public Machine machine { get; set; }
        //public IState State { get; set; }
        //public Context context { get; set; }
        public Form1()
        {
            InitializeComponent();
            machine = new Machine();
        }

        private void snackBtn_Click_1(object sender, EventArgs e)
        {
            
            machine.context.ChangeMode(machine.PurchaseMode);
            machine.context.State.ButtonsHandler(/*this- form*/);
            //reset buttons to payment mode
            // כדאי לעשות פונ בקלאס משין?
            // לכאורה מה הבעיה שהבטונס הנדלר יבצע את הרסיט?
        }

        private void coldDrinkBtn_Click(object sender, EventArgs e)
        {
            TxtReportBuilder txtReportBuilder = new TxtReportBuilder();
            txtReportBuilder.GetReport();
        }

        private void hotDrinkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}