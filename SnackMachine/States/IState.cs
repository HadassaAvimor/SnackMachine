namespace SnackMachine.States
{
    public interface IState
    {   
        public Context context { get; set; } //מצב נוכחי
        public static Form form = Application.OpenForms["form1"];
        //public Button BackBtn { get; set; }
        void ActionsHandler();
        void ButtonsHandler(Product product);

    }
}
