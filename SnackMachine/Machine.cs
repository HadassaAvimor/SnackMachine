using SnackMachine.ColdDrinks;
using SnackMachine.HotDrink;
using SnackMachine.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public class Machine
    {
        public Dictionary<Snack, int> Snacks { get; set; }
        //public List<HotDrinkDecorator> HotDrinks { get; set; }
        public Dictionary<ColdDrink, int> ColdDrinks { get; set; }

        public Machine(Dictionary<Snack, int> snacks, /*List<HotDrinkDecorator> hotDrinks,*/ Dictionary<ColdDrink, int> coldDrinks)
        {
           Snacks = snacks;
           //HotDrinks = hotDrinks;
           ColdDrinks = coldDrinks;
        }
    }
}
