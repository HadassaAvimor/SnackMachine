using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.HotDrinks
{
    public abstract class HotDrinkBuilder
    {
        protected HotDrink drink;

        public abstract void AddPowder();
        public abstract void AddSuger();
        public abstract void AddWater();
        public abstract void AddMilk();
        public abstract Product GetHotDrink();

    }
}
