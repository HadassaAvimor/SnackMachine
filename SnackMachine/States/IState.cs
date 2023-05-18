namespace SnackMachine.States
{
    public interface IState
    {
        //void HandleButtons<T>(string text, Dictionary<T, int> products) where T : Product;

        void Handle(Context context);
    }
}
