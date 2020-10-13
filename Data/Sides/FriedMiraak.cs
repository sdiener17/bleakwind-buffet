/*
* Author: Sarah Diener
* Class name: FriedMiraak.cs
* Purpose: Class used to represent the Fried Miraak side dish
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides {
    public class FriedMiraak : Side,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                if (size == Size.Small) { return 1.78; }
                if (size == Size.Medium) { return 2.01; }
                else { return 2.88; }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public override uint Calories {
            get {
                if (size == Size.Small) { return 151; }
                if (size == Size.Medium) { return 236; }
                else { return 306; }
            }
        }

        /// <summary>
        /// Getter/Setter for the size of side.
        /// </summary>
        private Size size = Size.Small;
        public override Size Size {
            get {
                return size;
            }
            set {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }



        /// <summary>
        /// Returns an empty list (no special instructions for sides).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        public FriedMiraak() {

        }


        /// <summary>
        /// Returns the name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() + " Fried Miraak";
        }
    }
}
