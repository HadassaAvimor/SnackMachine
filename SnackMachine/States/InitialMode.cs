using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States
{
    public class InitialMode : IState
    {
        public static Form form = Application.OpenForms["form1"];
        public Context context { get; set; }
        public Button BackBtn { get; set; }

        public InitialMode()
        {
            context = new Context(this);
        }
        public void ActionsHandler()
        {
            throw new NotImplementedException();
        }

        public void ButtonsHandler(Product product)
        {
            Label? title = form.Controls.Find("title", false).FirstOrDefault() as Label;
            title.Text = "?מה בא לך היום";

            form.Controls.Clear();

            //ליצור מחדש כפתורים, לנקות מסך
            Button snackBtn = new Button();
            form.Controls.Add(snackBtn);



            snackBtn.Width = 150;
            snackBtn.Height = 30;
            snackBtn.Text = "חטיפים";
            snackBtn.Location = new Point(200, 200);
            snackBtn.Name = "snackBtn";
            snackBtn.Click += (sender, e) =>
            {
                SnackPurchaseMode snackPurchaseMode = new SnackPurchaseMode();
                context.ChangeMode(snackPurchaseMode);
                context.State.ButtonsHandler(product);
            };
            }
    }
}
