using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackMachine.ColdDrinks;
using SnackMachine.HotDrink;
using SnackMachine.Snacks;

namespace SnackMachine.States
{
    public interface IState
    {
         void HandleButtons();

         void HandleActions();
    }
}
