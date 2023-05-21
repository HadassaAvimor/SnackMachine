using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Unipluss.Sign.ExternalContract.Entities;

namespace SnackMachine.States
{
    public class SnackPurchaseMode : IState
    {
        public static Form form { get; set; } = Application.OpenForms["form1"];
        public Context Context { get; set; }

        public SnackPurchaseMode(Context context)
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

            int x = 200;
            Label? title = new Label();
            title.Text = "כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה";
            title.Location = new Point(300, 50);
            title.Width = 500;
            form.Controls.Add(title);

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
            

            ComboBox comboBoxProduct = new();
            comboBoxProduct.Width = 150;
            comboBoxProduct.Height = 30;
            foreach (var item in Context.Stock.Snacks)
            {
                comboBoxProduct.Items.Add(item.Key);
            }

            form.Controls.Add(comboBoxProduct);
            Button selectedButton = new();
            selectedButton.Width = 150;
            selectedButton.Height = 30;
            selectedButton.Text = "בחר מוצר";
            selectedButton.Location = new Point(300, 200);
            form.Controls.Add(selectedButton);

            selectedButton.Click += (s, e) =>
            {
                selectedButton.Hide();
                comboBoxProduct.Hide();
                title.Hide();

                string name = comboBoxProduct.SelectedItem.ToString();
                double price = 0;

                if (Context.Stock.Snacks[name].Count > 0)
                {
                    price = Context.Stock.Snacks[name][0].Price;
                    Product product = Context.Stock.GetSnacksProduct(name);
                    Context.CurrentProduct = product;
                    PaymentMode paymentMode = new PaymentMode(Context);
                    Context.ChangeMode(paymentMode);
                    Context.State.ButtonsHandler();
                }
                else
                {
                    ////חסר מהמלאי
                }

            };
            



        }

    }
}
