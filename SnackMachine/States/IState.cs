namespace SnackMachine.States
{
    public interface IState
    {
        //void HandleButtons<T>(string text, Dictionary<T, int> products) where T : Product;
        public Context context { get; set; } //מצב נוכחי
        //void Handle(Context context);

        void StateActions();
        void ButtonsManagers();

    }
}
