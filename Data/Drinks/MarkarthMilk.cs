﻿/*
* Author: Sarah Diener
* Class name: MarkarthMilk.cs
* Purpose: Class used to represent the Markarth Milk drink
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks {
    public class MarkarthMilk : Drink,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the description of the item
        /// </summary>
        public string Description {
            get { return "Hormone-free organic 2% milk."; }
        }


        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                if (size == Size.Small) { return 1.05; }
                if (size == Size.Medium) { return 1.11; }
                else { return 1.22; }
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories {
            get {
                if (size == Size.Small) { return 56; }
                if (size == Size.Medium) { return 72; }
                else { return 93; }
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }





        /// <summary>
        /// Gets the special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (ice) { instructions.Add("Add ice"); }
                return instructions;
            }
        }


        public MarkarthMilk() {

        }


        /// <summary>
        /// Returns the name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() + " Markarth Milk";
        }
    }
}
