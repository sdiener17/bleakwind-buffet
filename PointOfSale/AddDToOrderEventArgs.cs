using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale {
    public class AddDToOrderEventArgs {

        public Drink orderItem;

        public AddDToOrderEventArgs(Drink d) {
            orderItem = d;
        }

    }
}
