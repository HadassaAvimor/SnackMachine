using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.HotDrinks;

public class Coffee : HotDrinkBuilder
{
    public Coffee()
    {
        drink = new HotDrink("קפוצ'ינו", 10);
    }
    public override void AddMilk()
    {
        drink.Milk = 30;
    }

    public override void AddPowder()
    {
        drink.Powder = 2;
    }

    public override void AddSuger()
    {
        drink.Suger = 1;
    }

    public override void AddWater()
    {
        drink.Water = 140;
    }

    public override Product GetHotDrink()
    {
        return drink;
    }
}
