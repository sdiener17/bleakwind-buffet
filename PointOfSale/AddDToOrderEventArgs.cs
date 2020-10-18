/*
* Author: Sarah Diener
* Class name: AddDToOrderEventArgs
* Purpose: Event args for adding a drink to the order
*/
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
