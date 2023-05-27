using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Unipluss.Sign.ExternalContract.Entities;

namespace SnackMachine.States
{
    public class ColdDrinkPurchaseMode : IState
    {
        public static Form form = Application.OpenForms["form1"];
        public Context Context { get; set; }

        public ColdDrinkPurchaseMode(Context context)
        {
            Context = context;
        }
        public void ActionsHandler()
        {
            throw new NotImplementedException();
        }

        public void ButtonsHandler()
        {
            int x = 200;

            form.Controls.Clear();

            Button back = new Button();
            back.Location = new Point(300, 20);
            back.Text = "למסך הקודם";
            back.Width = 200;
            form.Controls.Add(back);
            back.Click +=
                (sender, e) => {
                    InitialMode initialMode = new(Context);
                    Context.ChangeMode(initialMode);
                    Context.State.ButtonsHandler();
                };

            foreach (var item in Context.Stock.ColdDrinks)
            {
                Button btn = new Button();
                form.Controls.Add(btn);


                string name = item.Key;
                double price = 0;
                if (Context.Stock.ColdDrinks[name].Count > 0)
                {
                    price = Context.Stock.ColdDrinks[name][0].Price;
                    btn.Width = 150;
                    btn.Height = 30;
                    btn.Text = $"{name} ₪{price}";
                    btn.Location = new Point(x += 100, 200);
                    btn.Name = item.Key;
                    btn.Click += (sender, e) =>
                    {
                        Product product = Context.Stock.GetColdDrinksProduct(name);
                        Context.CurrentProduct = product;
                        PaymentMode paymentMode = new PaymentMode(Context);
                        Context.ChangeMode(paymentMode);
                        Context.State.ButtonsHandler();
                    };
                }
                else
                {
                    ///חסר מהמוצר
                }
            }
        }

    }
}
