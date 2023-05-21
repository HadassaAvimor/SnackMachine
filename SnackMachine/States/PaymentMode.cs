namespace SnackMachine.States
{
    public class PaymentMode : IState
    {
        double money;
        public static Form form = Application.OpenForms["form1"];
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
            form.Controls.Clear();
            int x = 200;

            Button back = new Button();
            back.Location = new Point(800, 20);
            form.Controls.Add(back);
            back.Click +=
                (sender, e) => {
                    InitialMode initialMode = new(Context);
                    Context.ChangeMode(initialMode);
                    Context.State.ButtonsHandler();

                };

            Label label = new Label();
            form.Controls.Add(label);
            label.Text = $" ₪{Context.CurrentProduct.Price} :לתשלום";
            label.Location = new Point(300, 100);

            CheckBox bag = new CheckBox();
            form.Controls.Add(bag);
            bag.Text = "שקית";
            bag.Location = new Point(250, 150);

            CheckBox giftWrap = new CheckBox();
            form.Controls.Add(giftWrap);
            giftWrap.Text = "אריזת מתנה";
            giftWrap.Location = new Point(370, 150);
            giftWrap.Width = 150;

            Label enterMoney = new Label();
            form.Controls.Add(enterMoney);
            enterMoney.Text = "הכנס כסף";
            enterMoney.Location = new Point(300, 200);

            NumericUpDown numericUpDown = new NumericUpDown();
            form.Controls.Add(numericUpDown);
            numericUpDown.Location = new Point(300, 250);

            Button toPayment = new Button();
            form.Controls.Add(toPayment);
            toPayment.Text = "השלם רכישה";
            toPayment.Location = new Point(300, 330);
            toPayment.Width = 150;
            toPayment.Height = 30;
            toPayment.Name = "toPayment";
            toPayment.Click += (sender, e) =>
            {
                if(bag.Checked)
                {
                    Context.CurrentProduct = new BagDecorator(Context.CurrentProduct);
                }
                if (giftWrap.Checked)
                {
                    Context.CurrentProduct = new GiftWrapDecorator(Context.CurrentProduct);
                }
                money = (double)numericUpDown.Value;
                ActionsHandler();
            };
            }

    }

}

