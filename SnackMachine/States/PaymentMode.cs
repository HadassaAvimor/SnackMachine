namespace SnackMachine.States
{
    public class PaymentMode : IState
    {
        public double money;
        public static Form1 form = (Form1)Application.OpenForms["form1"];
        public Context Context { get; set; }

        public PaymentMode(Context context)
        {
            Context = context;
        }
        public void ActionsHandler()
        {
            Label moneyDetails = new Label();
            form.Controls.Add(moneyDetails);
            moneyDetails.Location = new Point(350, 400);

            if (money < Context.CurrentProduct.Price)
            {
                moneyDetails.Text = $" ₪{Context.CurrentProduct.Price - money} חסר לך ";
            }
            else if(money > Context.CurrentProduct.Price)
            {
                MessageBox.Show($"{money - Context.CurrentProduct.Price} :עודף ,{Context.CurrentProduct.ToString()} קנית");
            }

            
        }

        public void ButtonsHandler()
        {
            form.ResetButtonsToPaymentMode();
        }

    }

}

