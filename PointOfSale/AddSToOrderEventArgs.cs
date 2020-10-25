/*
* Author: Sarah Diener
* Class name: AddSToOrderEventArgs.cs
* Purpose: Event args for adding a side to the order
*/
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
