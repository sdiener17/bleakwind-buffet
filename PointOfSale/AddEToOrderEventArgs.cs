using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale {
    public class AddEToOrderEventArgs :EventArgs {

        public Entree orderItem;

        public AddEToOrderEventArgs(Entree o) {
            orderItem = o;
        }
    }
}
