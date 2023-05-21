using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine
{
    public class Machine
    {
        public IState State { get; set; }
        public InitialMode InitialMode { get; set; } = new InitialMode();
        public PurchaseMode PurchaseMode { get; set; } = new PurchaseMode();
        public SnackPurchaseMode SnackPurchaseMode { get; set; } = new SnackPurchaseMode();
        public ColdDrinkPurchaseMode ColdDrinkPurchaseMode { get; set; } = new ColdDrinkPurchaseMode();
        public HotDrinkPurchaseMode HotDrinkPurchaseMode { get; set; } = new HotDrinkPurchaseMode();
        public PaymentMode PaymentMode { get; set; } = new PaymentMode();
        public AdminMode AdminMode { get; set; } = new AdminMode();
        public Context Context { get; set; }
        public Stock Stock { get; set; }

        public Machine(Stock stock)
        {
            Context = new Context(State);
            Stock = stock;
        }

        //אמור להימחק. רק בשביל ההרצה של הבילדר
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
