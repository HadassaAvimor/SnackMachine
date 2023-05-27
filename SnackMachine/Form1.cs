using SnackMachine.States;
using System.Security.Policy;

namespace SnackMachine;

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
            (sender, e) =>
            {
                InitialMode initialMode = new(Machine.Context);
                Machine.Context.ChangeMode(initialMode);
                Machine.Context.State.ButtonsHandler();
            };

        
            Button btn = new Button();
            Controls.Add(btn);
            btn.Text = "קפוצ'ינו";
            string name = "cappucino";
            double price = 10;
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

        Button btn1 = new Button();
        Controls.Add(btn1);
        btn1.Text = "שוקו";
        string name1 = "coco";
        double price1 = 10;
        btn1.Width = 150;
        btn1.Height = 30;
        btn1.Text = $"{name1} ₪{price1}";
        btn1.Location = new Point(x += 100, 200);
        btn1.Name = name1;
        btn1.Click += (sender, e) =>
        {
            Product product = Machine.Context.Stock.GetHotDrinksProduct(name1);
            Machine.Context.CurrentProduct = product;
            PaymentMode paymentMode = new PaymentMode(Machine.Context);
            Machine.Context.ChangeMode(paymentMode);
            Machine.Context.State.ButtonsHandler();
        };


    }

    public void ResetButtonsToColdDrinkPurchaseMode()
    {
        int x = 200;

        Controls.Clear();

        Button back = new Button();
        back.Location = new Point(300, 20);
        back.Text = "למסך הקודם";
        back.Width = 200;
        Controls.Add(back);
        back.Click +=
            (sender, e) =>
            {
                InitialMode initialMode = new(Machine.Context);
                Machine.Context.ChangeMode(initialMode);
                Machine.Context.State.ButtonsHandler();
            };

        foreach (var item in Machine.Context.Stock.ColdDrinks)
        {
            Button btn = new Button();
            Controls.Add(btn);


            string name = item.Key;
            double price = 0;
            if (Machine.Context.Stock.ColdDrinks[name].Count > 0)
            {
                price = Machine.Context.Stock.ColdDrinks[name][0].Price;
                btn.Width = 150;
                btn.Height = 30;
                btn.Text = $"{name} ₪{price}";
                btn.Location = new Point(x += 100, 200);
                btn.Name = item.Key;
                btn.Click += (sender, e) =>
                {
                    Product product = Machine.Context.Stock.GetColdDrinksProduct(name);
                    Machine.Context.CurrentProduct = product;
                    PaymentMode paymentMode = new PaymentMode(Machine.Context);
                    Machine.Context.ChangeMode(paymentMode);
                    Machine.Context.State.ButtonsHandler();
                };
            }
            else
            {
                ///חסר מהמוצר
            }
        }
    }

    public void ResetButtonsToSnackPurchaseMode()
    {
        Controls.Clear();

        int x = 200;
        Label? title = new Label();
        title.Text = "כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה";
        title.Location = new Point(300, 50);
        title.Width = 500;
        Controls.Add(title);

        Button back = new Button();
        back.Location = new Point(300, 20);
        back.Text = "למסך הקודם";
        back.Width = 200;
        Controls.Add(back);
        back.Click +=
            (sender, e) => {
                InitialMode initialMode = new(Machine.Context);
                Machine.Context.ChangeMode(initialMode);
                Machine.Context.State.ButtonsHandler();
            };


        ComboBox comboBoxProduct = new();
        comboBoxProduct.Width = 150;
        comboBoxProduct.Height = 30;
        foreach (var item in Machine.Context.Stock.Snacks)
        {
            comboBoxProduct.Items.Add(item.Key);
        }

        Controls.Add(comboBoxProduct);
        Button selectedButton = new();
        selectedButton.Width = 150;
        selectedButton.Height = 30;
        selectedButton.Text = "בחר מוצר";
        selectedButton.Location = new Point(300, 200);
        Controls.Add(selectedButton);

        selectedButton.Click += (s, e) =>
        {
            selectedButton.Hide();
            comboBoxProduct.Hide();
            title.Hide();

            string name = comboBoxProduct.SelectedItem.ToString();
            double price = 0;

            if (Machine.Context.Stock.Snacks[name].Count > 0)
            {
                price = Machine.Context.Stock.Snacks[name][0].Price;
                Product product = Machine.Context.Stock.GetSnacksProduct(name);
                Machine.Context.CurrentProduct = product;
                PaymentMode paymentMode = new PaymentMode(Machine.Context);
                Machine.Context.ChangeMode(paymentMode);
                Machine.Context.State.ButtonsHandler();
            }
            else
            {
                ////חסר מהמלאי
            }

        };




    }

    public void ResetButtonsToPaymentMode()
    {
        Controls.Clear();
        int x = 200;

        Button back = new Button();
        back.Location = new Point(800, 20);
        Controls.Add(back);
        back.Click +=
            (sender, e) => {
                InitialMode initialMode = new(Machine.Context);
                Machine.Context.ChangeMode(initialMode);
                Machine.Context.State.ButtonsHandler();

            };

        Label label = new Label();
        Controls.Add(label);
        label.Text = $" ₪{Machine.Context.CurrentProduct.Price} :לתשלום";
        label.Location = new Point(300, 100);

        CheckBox bag = new CheckBox();
        Controls.Add(bag);
        bag.Text = "שקית";
        bag.Location = new Point(250, 150);

        CheckBox giftWrap = new CheckBox();
        Controls.Add(giftWrap);
        giftWrap.Text = "אריזת מתנה";
        giftWrap.Location = new Point(370, 150);
        giftWrap.Width = 150;

        Label enterMoney = new Label();
        Controls.Add(enterMoney);
        enterMoney.Text = "הכנס כסף";
        enterMoney.Location = new Point(300, 200);

        NumericUpDown numericUpDown = new NumericUpDown();
        Controls.Add(numericUpDown);
        numericUpDown.Location = new Point(300, 250);

        Button toPayment = new Button();
        Controls.Add(toPayment);
        toPayment.Text = "השלם רכישה";
        toPayment.Location = new Point(300, 330);
        toPayment.Width = 150;
        toPayment.Height = 30;
        toPayment.Name = "toPayment";
        toPayment.Click += (sender, e) =>
        {
            if (bag.Checked)
            {
                Machine.Context.CurrentProduct = new BagDecorator(Machine.Context.CurrentProduct);
            }
            if (giftWrap.Checked)
            {
                Machine.Context.CurrentProduct = new GiftWrapDecorator(Machine.Context.CurrentProduct);
            }
            Machine.PaymentMode.money = (double)numericUpDown.Value;
            Machine.PaymentMode.ActionsHandler();
        };
    }

    public void InitialButtons()
    {
        Controls.Clear();

        Label title = new Label();
        title.Text = "?מה בא לך היום";
        title.Location = new Point(500, 50);
        Controls.Add(title);

        Button snackBtn = new Button();
        Controls.Add(snackBtn);
        snackBtn.Width = 150;
        snackBtn.Height = 30;
        snackBtn.Text = "חטיפים";
        snackBtn.Location = new Point(100, 100);
        snackBtn.Name = "snackBtn";
        snackBtn.Click += (sender, e) =>
        {
            SnackPurchaseMode snackPurchaseMode = new SnackPurchaseMode(Machine.Context);
            Machine.Context.ChangeMode(snackPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        };

        Button coldDrindBtn = new Button();
        Controls.Add(coldDrindBtn);
        coldDrindBtn.Width = 150;
        coldDrindBtn.Height = 30;
        coldDrindBtn.Text = "שתיה קרה";
        coldDrindBtn.Location = new Point(300, 100);
        coldDrindBtn.Name = "coldDrindBtn";
        coldDrindBtn.Click += (sender, e) =>
        {
            ColdDrinkPurchaseMode coldDrinkPurchaseMode = new ColdDrinkPurchaseMode(Machine.Context);
            Machine.Context.ChangeMode(coldDrinkPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        };

        Button hotDrinkBtn = new Button();
        Controls.Add(hotDrinkBtn);
        hotDrinkBtn.Width = 150;
        hotDrinkBtn.Height = 30;
        hotDrinkBtn.Text = "שתיה חמה";
        hotDrinkBtn.Location = new Point(500, 100);
        hotDrinkBtn.Name = "hotDrinkBtn";
        hotDrinkBtn.Click += (sender, e) =>
        {
            HotDrinkPurchaseMode hotDrinkPurchaseMode = new HotDrinkPurchaseMode(Machine.Context);
            Machine.Context.ChangeMode(hotDrinkPurchaseMode);
            Machine.Context.State.ButtonsHandler();
        };
    }
}






