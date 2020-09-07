/*
* Author: Sarah Diener
* Class name: VokunSalad.cs
* Purpose: Class used to represent the Vokun Salad side dish
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides {
    public class VokunSalad {

        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public double Price {
            get {
                if (size == Size.Small) { return 0.93; }
                if (size == Size.Medium) { return 1.28; }
                else { return 1.82; }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public uint Calories {
            get {
                if (size == Size.Small) { return 41; }
                if (size == Size.Medium) { return 52; }
                else { return 73; }
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


        public VokunSalad() {

        }


        /// <summary>
        /// Returns the name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() +" Vokun Salad";
        }
    }
}
