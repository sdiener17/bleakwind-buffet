using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    public class AddSToOrderEventArgs {

        public Side orderItem;

        public AddSToOrderEventArgs(Side s) {
            orderItem = s;
        }
    }
}
