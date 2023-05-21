namespace SnackMachine.States
{
    public class PaymentMode : IState
    {
        public static Form form = Application.OpenForms["form1"];
        public Context context { get; set; }

        public PaymentMode()
        {
            context = new Context(this);
        }
        public void ActionsHandler()
        {
            throw new NotImplementedException();
        }

        public void ButtonsHandler(Product product)
        {
            int x = 200;
            Label? title = form.Controls.Find("title", false).FirstOrDefault() as Label;
            title.Text = "לפום צערא אגרא";


            foreach (var item in context.Stock.Snacks)
            {
                Button? btn = form.Controls.Find($"{item.Key.Name}", false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }

            foreach (var item in context.Stock.ColdDrinks)
            {
                Button? btn = form.Controls.Find($"{item.Key.Name}", false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }

            foreach (var item in context.Stock.HotDrinks)
            {
                Button? btn = form.Controls.Find($"{item.Key.Name}", false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }

            Label label = new Label();
            form.Controls.Add(label);
            label.Text = $" ₪{product.Price} :לתשלום";
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

            TextBox textBox = new TextBox();
            form.Controls.Add(textBox);
            textBox.Location = new Point(300, 250);

            Button toPayment = new Button();
            form.Controls.Add(toPayment);
            toPayment.Text = "השלם רכישה";
            toPayment.Location = new Point(300, 330);
            toPayment.Width = 150;
            toPayment.Height = 30;
            toPayment.Click += (sender, e) =>
            {
                //לבדוק כמה כסף הכניס ולהחזיר עודף
                //לבדוק אם המוצר נגמר ואם כן להודיע לספק
                //לכתוב את הרכישה בקובץ טקסט
                //להדפיס לו את המוצר עם השקית והאריזת מתנה
                context.Stock.DeleteProduct(product);
            };
            }

    }

}

