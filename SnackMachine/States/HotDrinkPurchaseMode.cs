using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnackMachine.States
{
    public class HotDrinkPurchaseMode : IState
    {
        public static Form form = Application.OpenForms["form1"];
        public Context Context { get; set; }
        //public Button BackBtn { get; set; } = form.Controls.Find("back", false).First() as Button;

        public HotDrinkPurchaseMode(Context context)
        {
            Context = context;
        }
        public void ActionsHandler()
        {
            
        }

        public void ButtonsHandler()
        {
            
            int x = 200;
            form.Controls.Clear();

            Label? title = new Label();
            title.Text = "פיהוק הוא צעקה שקטה לקפה";
            title.Location = new Point(300, 50);
            title.Width = 500;
            form.Controls.Add(title);
            

            //Button? coldDrinkBtn = form.Controls.Find("coldDrinkBtn", false).FirstOrDefault() as Button;
            //Button? hotDrinkBtn = form.Controls.Find("hotDrinkBtn", false).FirstOrDefault() as Button;
            //Button? snackBtn = form.Controls.Find("snackBtn", false).FirstOrDefault() as Button;

            //form.Controls.Remove(coldDrinkBtn);
            //form.Controls.Remove(hotDrinkBtn);
            //form.Controls.Remove(snackBtn);

            Button back = new Button();
            back.Location = new Point(300, 20);
            back.Text = "חזור להתחלה";
            back.Width = 200;
            form.Controls.Add(back);
            back.Click +=
                (sender, e) => {
                    InitialMode initialMode = new(Context);
                    Context.ChangeMode(initialMode);
                    Context.State.ButtonsHandler();
                };

            foreach (var item in Context.Stock.HotDrinks)
            {
                Button btn = new Button();
                form.Controls.Add(btn);

                string name = item.Key;
                double price = 0;

                if(Context.Stock.HotDrinks.Count > 0)
                {
                    price = Context.Stock.HotDrinks[name][0].Price;
                    btn.Width = 150;
                    btn.Height = 30;
                    btn.Text = $"{name} ₪{price}";
                    btn.Location = new Point(x += 100, 200);
                    btn.Name = name;
                    btn.Click += (sender, e) =>
                    {
                        Product product = Context.Stock.GetHotDrinksProduct(name);
                        Context.CurrentProduct = product;
                        PaymentMode paymentMode = new PaymentMode(Context);
                        Context.ChangeMode(paymentMode);
                        Context.State.ButtonsHandler();
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
