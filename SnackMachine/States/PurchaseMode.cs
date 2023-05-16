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

namespace SnackMachine.States;

public class PurchaseMode : IState
{

    public PurchaseMode()
    {
        Stock stock = new Stock();
    }
    public void ClickSnackBtn()
    {
        var form1 = Application.OpenForms["Form1"];
        int x = 200;
        Label? title = form1.Controls.Find("title", false).FirstOrDefault() as Label;
        title.Text = "כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה";

        Button? coldDrinkBtn = form1.Controls.Find("coldDrinkBtn", false).FirstOrDefault() as Button;
        Button? hotDrinkBtn = form1.Controls.Find("hotDrinkBtn", false).FirstOrDefault() as Button;
        Button? snackBtn = form1.Controls.Find("snackBtn", false).FirstOrDefault() as Button;

        form1.Controls.Remove(coldDrinkBtn);
        form1.Controls.Remove(hotDrinkBtn);
        form1.Controls.Remove(snackBtn);

        //var a = form1.GetType().GetProperty("snacks");
        //foreach (var item in )
        //{
        //    Button btn = new Button();
        //    form1.Controls.Add(btn);
        //    btn.Text = item.Key.Name;
        //    btn.Location = new Point(x += 75, 100);
        //}
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
