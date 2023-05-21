using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States
{
    public class Context //manager
    {
        public IState? State { get; set; }
        public Stock Stock { get; set; }
        public Product CurrentProduct { get; set; }//enum

        public Context(IState initialState, Stock stock)
        {
            State = initialState;
            Stock = stock;
        }
        public void ChangeMode(IState state)
        {
            State = state;
            state.Context = this;
        }

        
    }
}
