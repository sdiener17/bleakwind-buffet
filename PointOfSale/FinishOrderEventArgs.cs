using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    public class FinishOrderEventArgs :EventArgs {

        public List<Entree> entrees = new List<Entree>();
        public List<Side> sides = new List<Side>();
        public List<Drink> drinks = new List<Drink>();

        public FinishOrderEventArgs(List<Entree> en, List<Side> s, List<Drink> d) {
            entrees = en;
            sides = s;
            drinks = d;
        }
    }
}
