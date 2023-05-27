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

        public void ResetButtonsToHotDrinkPurchaseMode()
        {

            int x = 200;
            Controls.Clear();

            Label? title = new Label();
            title.Text = "פיהוק הוא צעקה שקטה לקפה";
            title.Location = new Point(300, 50);
            title.Width = 500;
            Controls.Add(title);

            Button back = new Button();
            back.Location = new Point(300, 20);
            back.Text = "חזור להתחלה";
            back.Width = 200;
            Controls.Add(back);
            back.Click +=
                (sender, e) => {
                    InitialMode initialMode = new(Machine.Context);
                    Machine.Context.ChangeMode(initialMode);
                    Machine.Context.State.ButtonsHandler();
                };

            foreach (var item in Machine.Context.Stock.HotDrinks)
            {
                Button btn = new Button();
                Controls.Add(btn);

                string name = item.Key;
                double price = 0;

                if (Machine.Context.Stock.HotDrinks.Count > 0)
                {
                    price = Machine.Context.Stock.HotDrinks[name][0].Price;
                    btn.Width = 150;
                    btn.Height = 30;
                    btn.Text = $"{name} ₪{price}";
                    btn.Location = new Point(x += 100, 200);
                    btn.Name = name;
                    btn.Click += (sender, e) =>
                    {
                        Product product = Machine.Context.Stock.GetHotDrinksProduct(name);
                        Machine.Context.CurrentProduct = product;
                        PaymentMode paymentMode = new PaymentMode(Machine.Context);
                        Machine.Context.ChangeMode(paymentMode);
                        Machine.Context.State.ButtonsHandler();
                    };
                }
                else
                {
                    ///חסר מוצר
                }
            }
        }
    }
    }
