using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.HotDrinks;

public class Coco : HotDrinkBuilder
{
    public Coco()
    {
        drink = new HotDrink("שוקו", 16);
    }
    public override void AddMilk()
    {
        drink.Milk = 50;
    }

    public override void AddPowder()
    {
        drink.Powder = 1.5;
    }

    public override void AddSuger()
    {
        drink.Suger = 0;
    }

    public override void AddWater()
    {
        drink.Water = 120;
    }

    public override Product GetHotDrink()
    {
        return drink;
    }
}
