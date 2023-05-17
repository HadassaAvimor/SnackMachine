using SnackMachine.ColdDrinks;
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
        public Dictionary<ColdDrink, int> ColdDrinks { get; set; }

        public Dictionary<HotDrink, int> HotDrinks { get; set; }

        public Machine(Dictionary<Snack, int> snacks, Dictionary<ColdDrink, int> coldDrinks, Dictionary<HotDrink, int> hotDrinks)
        {
            Snacks = snacks;
            ColdDrinks = coldDrinks;
            HotDrinks = hotDrinks;
        }
    }
}
