using SnackMachine.ColdDrinks;
using SnackMachine.HotDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States
{
    public class PaymentMode : IState
    {
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

        void IState.ClickColdDrinkBtn()
        {
            throw new NotImplementedException();
        }

        void IState.ClickHotDrinkBtn()
        {
            throw new NotImplementedException();
        }
    }
}
