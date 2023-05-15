using SnackMachine.ColdDrinks;
using SnackMachine.Snacks;

namespace SnackMachine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}