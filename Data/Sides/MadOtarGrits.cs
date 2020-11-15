﻿/*
* Author: Sarah Diener
* Class name: MadOtarGrits.cs
* Purpose: Class used to represent the Mad Otar Grits side dish
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides {
    public class MadOtarGrits : Side,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the item
        /// </summary>
        public string Description {
            get { return "Cheesey Grits."; }
        }



        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                if (size == Size.Small) { return 1.22; }
                if (size == Size.Medium) { return 1.58; }
                else { return 1.93; }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public override uint Calories {
            get {
                if (size == Size.Small) { return 105; }
                if (size == Size.Medium) { return 142; }
                else { return 179; }
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


        public MadOtarGrits() {

        }


        /// <summary>
        /// Returns the name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() + " Mad Otar Grits";
        }
    }
}
