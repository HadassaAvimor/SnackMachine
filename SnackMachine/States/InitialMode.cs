using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States;

public class InitialMode : IState
{
    public static Form1 form = (Form1)Application.OpenForms["form1"];
    public Context Context { get; set; }
    public Button BackBtn { get; set; }

    public InitialMode(Context context)
    {
        Context = context;
    }
    public void ActionsHandler()
    {
        throw new NotImplementedException();
    }

    public void ButtonsHandler()
    {
        form.InitialButtons();
    }
}
