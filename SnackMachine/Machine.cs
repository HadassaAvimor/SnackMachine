using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;
using SnackMachine.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine;

public class Machine
{
    public IState State { get; set; }
    public InitialMode InitialMode { get; set; }
    public SnackPurchaseMode SnackPurchaseMode { get; set; }
    public ColdDrinkPurchaseMode ColdDrinkPurchaseMode { get; set; }
    public HotDrinkPurchaseMode HotDrinkPurchaseMode { get; set; }
    public PaymentMode PaymentMode { get; set; }
    public Context Context { get; set; }
    public Stock Stock { get; set; }

    public Machine(Stock stock)
    {
        Context = new Context(InitialMode, stock);
        SnackPurchaseMode = new SnackPurchaseMode(Context);
        ColdDrinkPurchaseMode = new ColdDrinkPurchaseMode(Context);
        PaymentMode = new PaymentMode(Context);
        HotDrinkPurchaseMode = new HotDrinkPurchaseMode(Context);
        InitialMode = new InitialMode(Context);
        Stock = stock;

    }
}
