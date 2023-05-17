using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;

namespace SnackMachine.States;

public class PurchaseMode : IState
{
    public static Stock stock = new Stock();

    public static Form form = Application.OpenForms["form1"];


    private void AddButtons<T>(string text, Dictionary<T, int> products)
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

            btn.Width = 100;
            btn.Text = $"{item.Key.Name} ₪{item.Key.Price}";
            btn.Location = new Point(x += 105, 100);
            btn.Name = item.Key.Name;
            btn.Click += (sender, e) =>
            {
                Purchase(item.Key);
            };
        }
    }

    public void ClickSnackBtn()
    {
        AddButtons("כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה", stock.snacks);
    }


    public void ClickHotDrinkBtn()
    {
        throw new NotImplementedException();
    }

    public void ClickColdDrinkBtn()
    {
        AddButtons("Hello, Yoram;", stock.coldDrinks);
    }

    public int GetAmount(Product product)
    {
        int amount = 0;
        string type = "";

        if (product is Snack)
        {
            amount = stock.snacks[(Snack)product];
            type += "Snack";
        }
        else if (product is ColdDrink)
        {
            amount = stock.coldDrinks[(ColdDrink)product];
            type += "ColdDrink";
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


            foreach (var item in stock.snacks)
            {
                Button? btn = form.Controls.Find(item.Key.Name, false).FirstOrDefault() as Button;
                form.Controls.Remove(btn);
            }
            foreach (var item in stock.coldDrinks)
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

    public void HandleButtons()
    {
        throw new NotImplementedException();
    }

    public void HandleActions()
    {
        throw new NotImplementedException();
    }
}
