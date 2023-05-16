using SnackMachine.ColdDrinks;
using SnackMachine.HotDrink;
using SnackMachine.Snacks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SnackMachine.States;

public class PurchaseMode : IState
{
    public Stock stock { get; }
    public static Form form = Application.OpenForms["form"];
    public PurchaseMode()
    {
        //injection
       stock = new Stock();
    }

    private void AddButtons<T>(string text, Dictionary<T, int> products)
        where T : Product
    {
        int x = 200;
        Label title = form.Controls.Find("title", false).FirstOrDefault() as Label;
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
            btn.Text = item.Key.Name;
            btn.Location = new Point(x += 75, 100);
        }
    }

    public void ClickSnackBtn()
    {
        AddButtons("כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה", stock.snacks);
    }

    public HotDrinkDecorator ClickHotDrinkBtn()
    {
        throw new NotImplementedException();
    }

    public ColdDrink ClickColdDrinkBtn()
    {
        throw new NotImplementedException();
    }

    public void ClickPaymentBtn()
    {
        throw new NotImplementedException();
    }

    public GiftWrap AddGiftWrap()
    {
        return new GiftWrap();
    }
    public Bag AddBag()
    {
        return new Bag();
    }
}
