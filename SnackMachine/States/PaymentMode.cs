using SnackMachine.ColdDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States
{
    public class PaymentMode : IState
    {
        public void Handle(Context context)
        {
            MessageBox.Show("payment mode");

            context.State = new PaymentMode(); // Transition to the next state
        }
        public ColdDrink ClickColdDrinkBtn()
        {
            throw new NotImplementedException();
        }

        public HotDrinkDecorator ClickHotDrinkBtn()
        {
            throw new NotImplementedException();
        }

        public void ClickPaymentBtn()
        {
            throw new NotImplementedException();
        }

        public void ClickSnackBtn()
        {
            throw new NotImplementedException();
        }

        public void HandleActions()
        {
            throw new NotImplementedException();
        }


    }
}
