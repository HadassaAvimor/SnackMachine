using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public class State : IButtons
    {
        public Machine PlayMachine()
        {
            return new Machine();
        }
        public Snack ClickSnackBtn()
        {
            return new Snack();
        }

        public HotDrink ClickHotDrinkBtn()
        {
            return new HotDrink();
        }

        public ColdDrink ClickColdDrinkBtn()
        {
            return new ColdDrink();
        }

        public void ClickPaymentBtn()
        {

        }
    }
}
