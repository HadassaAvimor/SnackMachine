using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States;

public class InitialMode : IState
{
    public static Form form = Application.OpenForms["form1"];
    public Context Context { get; set; }
    public Button BackBtn { get; set; }

    public InitialMode(Context context)
    {
        Context = context;
    }
    public void ActionsHandler()
    {
        throw new NotImplementedException();
    }

    public void ButtonsHandler()
    {
        form.Controls.Clear();

        Label title = new Label();
        title.Text = "?מה בא לך היום";
        title.Location = new Point(500, 50);
        form.Controls.Add(title);

        Button snackBtn = new Button();
        form.Controls.Add(snackBtn);
        snackBtn.Width = 150;
        snackBtn.Height = 30;
        snackBtn.Text = "חטיפים";
        snackBtn.Location = new Point(100, 100);
        snackBtn.Name = "snackBtn";
        snackBtn.Click += (sender, e) =>
        {
            SnackPurchaseMode snackPurchaseMode = new SnackPurchaseMode(Context);
            Context.ChangeMode(snackPurchaseMode);
            Context.State.ButtonsHandler();
        };

        Button coldDrindBtn = new Button();
        form.Controls.Add(coldDrindBtn);
        coldDrindBtn.Width = 150;
        coldDrindBtn.Height = 30;
        coldDrindBtn.Text = "שתיה קרה";
        coldDrindBtn.Location = new Point(300, 100);
        coldDrindBtn.Name = "coldDrindBtn";
        coldDrindBtn.Click += (sender, e) =>
        {
            ColdDrinkPurchaseMode coldDrinkPurchaseMode = new ColdDrinkPurchaseMode(Context);   
            Context.ChangeMode(coldDrinkPurchaseMode);
            Context.State.ButtonsHandler();
        };

        Button hotDrinkBtn = new Button();
        form.Controls.Add(hotDrinkBtn);
        hotDrinkBtn.Width = 150;
        hotDrinkBtn.Height = 30;
        hotDrinkBtn.Text = "שתיה חמה";
        hotDrinkBtn.Location = new Point(500, 100);
        hotDrinkBtn.Name = "hotDrinkBtn";
        hotDrinkBtn.Click += (sender, e) =>
        {
            HotDrinkPurchaseMode hotDrinkPurchaseMode = new HotDrinkPurchaseMode(Context);
            Context.ChangeMode(hotDrinkPurchaseMode);
            Context.State.ButtonsHandler();
        };
    }
}
