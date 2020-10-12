/*
* Author: Sarah Diener
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent the Candlehearth Coffee drink
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks {
    public class CandlehearthCoffee : Drink,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                if (size == Size.Small) { return 0.75; }
                if (size == Size.Medium) { return 1.25; }
                else { return 1.75; }
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories {
            get {
                if (size == Size.Small) { return 7; }
                if (size == Size.Medium) { return 10; }
                else { return 20; }
            }
        }

        /// <summary>
        /// Getter/Setter for the size of drink.
        /// </summary>
        private Size size = Size.Small;
        public override Size Size {
            get {
                return size;
            }
            set {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(size.ToString()));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Price.ToString()));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Calories.ToString()));
            }
        }

        /// <summary>
        /// Getter/Setter for if ice is wanted.
        /// </summary>
        private bool ice = false;
        public bool Ice {
            get { return ice; }
            set { ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// Getter/Setter for if cream is wanted.
        /// </summary>
        private bool roomforcream = false;
        public bool RoomForCream {
            get { return roomforcream; }
            set{ roomforcream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
            }
        }

        /// <summary>
        /// Getter/Setter for if decaf is wanted.
        /// </summary>
        private bool decaf = false;
        public bool Decaf {
            get { return decaf; }
            set { decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <summary>
        /// Gets the special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (ice) { instructions.Add("Add ice"); }
                if (roomforcream) { instructions.Add("Add cream"); }
                return instructions;
            }
        }


        public CandlehearthCoffee() {

        }


        /// <summary>
        /// Returns the name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            if(decaf) { return size + " Decaf Candlehearth Coffee"; }
            return size.ToString() + " Candlehearth Coffee";
        }
    }
}
