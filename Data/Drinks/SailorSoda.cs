/*
* Author: Sarah Diener
* Class name: SailorSoda.cs
* Purpose: Class used to represent the Sailor Soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks {
    public class SailorSoda {
        
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price {
            get {
                if(size==Size.Small){ return 1.42; }
                if(size==Size.Medium){ return 1.74; }
                else{ return 2.07; }
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories {
            get {
                if (size == Size.Small) { return 117; }
                if (size == Size.Medium) { return 153; }
                else { return 205; }
            }
        }

        /// <summary>
        /// Getter/Setter for the size of drink.
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
        /// Getter/Setter for if ice is wanted.
        /// </summary>
        private bool ice = true;
        public bool Ice {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Getter/Setter for the flavor.
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor {
            get {
                return flavor;
            }
            set {
                flavor = value;
            }
        }

      

        /// <summary>
        /// Gets the special instructions for the drink.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!ice) { instructions.Add("Hold ice"); }
                return instructions;
            }
        }


        public SailorSoda() {

        }


        /// <summary>
        /// Returns the name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() + flavor.ToString()+ " Sailor Soda";
        }
    }
}
