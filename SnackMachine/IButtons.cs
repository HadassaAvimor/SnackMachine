using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public interface IButtons
    {
        public Snack ClickSnackBtn();

        public HotDrink ClickHotDrinkBtn();

        public ColdDrink ClickColdDrinkBtn();

        public void ClickPaymentBtn();
    }
}
