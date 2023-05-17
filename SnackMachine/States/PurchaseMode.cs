using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;

namespace SnackMachine.States;

public class PurchaseMode : IState
{
    public static Stock stock = new Stock();

    public static Form form = Application.OpenForms["form1"];


     

    public void ClickSnackBtn()
    {
        HandleButtons("כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה", stock.Snacks);
    }


    public void ClickHotDrinkBtn()
    {
        HandleButtons("פיהוק הוא צעקה שקטה לקפה", stock.HotDrinks);
    }

    public void ClickColdDrinkBtn()
    {
        HandleButtons("Hello, Yoram;", stock.ColdDrinks);
    }

    public int GetAmount(Product product)
    {
        int amount = 0;
        //string type = "";

        if (product is Snack)
        {
            amount = stock.Snacks[(Snack)product];
            //type += "Snack";
        }
        else if (product is ColdDrink)
        {
            amount = stock.ColdDrinks[(ColdDrink)product];
            //type += "ColdDrink";
        }
        else if (product is HotDrink)
        {
            amount = stock.HotDrinks[(HotDrink)product];
            //type += "ColdDrink";
        }
        return amount;
    }

    public void Purchase(Product product)
    {
        Label? title = form.Controls.Find("title", false).FirstOrDefault() as Label;

        if (GetAmount(product) > 0)
        {
            title.Text = $"₪{product.Price} :לתשלום";

            CheckBox giftWrap = new CheckBox();
            giftWrap.Text = "אריזת מתנה";
            giftWrap.Location = new Point(200, 100);
            form.Controls.Add(giftWrap);

            CheckBox bag = new CheckBox();
            bag.Text = "שקית";
            bag.Location = new Point(400, 100);
            form.Controls.Add(bag);


            foreach (var item in stock.Snacks)
            {
                Button? btn = form.Controls.Find(item.Key.Name, false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }
            foreach (var item in stock.ColdDrinks)
            {
                Button? btn = form.Controls.Find(item.Key.Name, false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }
            foreach (var item in stock.HotDrinks)
            {
                Button? btn = form.Controls.Find(item.Key.Name, false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }

            Button button = new Button();
            button.Text = "המשך לתשלום";
            button.Location = new Point(300, 200);
            button.Width = 150;
            button.Click += (sender, e) =>
            {
                if (giftWrap.Checked)
                {
                    AddGiftWrap();
                }
                if (bag.Checked)
                {
                    AddBag();
                }
            };
            form.Controls.Add(button);

        }
        else
        {
            title.Text = "מצטערים, מוצר זה אינו זמין כרגע";
            // לדווח לספק!!!!!!!!!!!!!
        }
    }

    public GiftWrap AddGiftWrap()
    {
        return new GiftWrap();
    }
    public Bag AddBag()
    {
        return new Bag();
    }


    public void HandleActions()
    {
        throw new NotImplementedException();
    }

    void HandleButtons<T>(string text, Dictionary<T, int> products)
        where T : Product
    {
        int x = 200;
        Label? title = form.Controls.Find("title", false).FirstOrDefault() as Label;
        title.Text = text;

        Button? coldDrinkBtn = form.Controls.Find("coldDrinkBtn", false).FirstOrDefault() as Button;
        Button? hotDrinkBtn = form.Controls.Find("hotDrinkBtn", false).FirstOrDefault() as Button;
        Button? snackBtn = form.Controls.Find("snackBtn", false).FirstOrDefault() as Button;

        form.Controls.Remove(coldDrinkBtn);
        form.Controls.Remove(hotDrinkBtn);
        form.Controls.Remove(snackBtn);

        foreach (var item in products)
        {
            Button btn = new Button();
            form.Controls.Add(btn);

            btn.Width = 150;
            btn.Height = 30;
            btn.Text = $"{item.Key.Name} ₪{item.Key.Price}";
            btn.Location = new Point(x += 100, 200);
            btn.Name = item.Key.Name;
            btn.Click += (sender, e) =>
            {
                Purchase(item.Key);
            };
        }
    }
}
