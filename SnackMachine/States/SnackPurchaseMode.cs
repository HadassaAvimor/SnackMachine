//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SnackMachine.States
//{
//    public class SnackPurchaseMode : IState
//    {
//        public void Handle(Context context)
//        {
//            MessageBox.Show("snack purchese mode");
//            PurchaseMode.HandleButtons("כל החטיפים מיוצרים מקמח שנטחן לאחר הפסח, במיוחד הבמבה", PurchaseMode.stock.Snacks);
//            context.State = new PaymentMode(); // Transition to the next state
//        }
//    }
//}
