using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.States
{
    public class PurchaseMode : State
    {
        // change it to builder!!!!!! 😉😉
        public GiftWrap AddGiftWrap()
        {
            return new GiftWrap();
        }
        public Bag AddBag()
        {
            return new GiftWrap();
        }
    }
}
