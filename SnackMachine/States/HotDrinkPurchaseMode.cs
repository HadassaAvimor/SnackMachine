using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnackMachine.States
{
    public class HotDrinkPurchaseMode : IState
    {
        public static Form1 form = (Form1)Application.OpenForms["form1"];
        public Context Context { get; set; }
        public HotDrinkPurchaseMode(Context context)
        {
            Context = context;
        }
        public void ActionsHandler()
        {
            
        }

        public void ButtonsHandler()
        {
            form.ResetButtonsToHotDrinkPurchaseMode();
        }

        
    }
}
