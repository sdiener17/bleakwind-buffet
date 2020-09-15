/*
* Author: Sarah Diener
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Dragonborn Waffle Fries side dish
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides {
    public class DragonbornWaffleFries : Side,IOrderItem{
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                if (size == Size.Small) { return 0.42; }
                if (size == Size.Medium) { return 0.76; }
                else { return 0.96; }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public override uint Calories {
            get {
                if (size == Size.Small) { return 77; }
                if (size == Size.Medium) { return 89; }
                else { return 100; }
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


        public DragonbornWaffleFries() {

        }


        /// <summary>
        /// Returns the name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString()+" Dragonborn Waffle Fries";
        }
    }
}
