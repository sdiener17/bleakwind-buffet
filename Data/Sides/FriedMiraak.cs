﻿/*
* Author: Sarah Diener
* Class name: FriedMiraak.cs
* Purpose: Class used to represent the Fried Miraak side dish
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides {
    class FriedMiraak {

        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public double Price {
            get {
                if (size == Size.Small) { return 1.78; }
                if (size == Size.Medium) { return 2.01; }
                else { return 2.88; }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public uint Calories {
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
        public Size Size {
            get {
                return size;
            }
            set {
                size = value;
            }
        }



        /// <summary>
        /// Returns an empty list (no special instructions for sides).
        /// </summary>
        public List<string> SpecialInstructions {
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
            return size.ToString() + "Fried miraak";
        }
    }
}
