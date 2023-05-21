namespace SnackMachine.States
{
    public interface IState
    {   
        public Context Context { get; set; } //מצב נוכחי
        public static Form form = Application.OpenForms["form1"];
        void ActionsHandler();
        void ButtonsHandler();

    }
}
