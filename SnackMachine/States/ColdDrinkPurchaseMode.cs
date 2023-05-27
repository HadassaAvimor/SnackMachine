namespace SnackMachine.States
{
    public class ColdDrinkPurchaseMode : IState
    {
        public static Form1 form = (Form1)Application.OpenForms["form1"];
        public Context Context { get; set; }

        public ColdDrinkPurchaseMode(Context context)
        {
            Context = context;
        }
        public void ActionsHandler()
        {
            throw new NotImplementedException();
        }

        public void ButtonsHandler()
        {
            form.ResetButtonsToColdDrinkPurchaseMode();
        }

    }
}
