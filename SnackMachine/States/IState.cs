namespace SnackMachine.States
{
    public interface IState
    {   
        public Context context { get; set; } //מצב נוכחי
        void ActionsHandler();
        void ButtonsHandler();

    }
}
