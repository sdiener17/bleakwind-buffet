using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks {
    class MarkarthMilk {

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price {
            get {
                if (size == Size.Small) { return 1.05; }
                if (size == Size.Medium) { return 1.11; }
                else { return 1.22; }
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories {
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
        private bool ice = false;
        public bool Ice {
            get { return ice; }
            set { ice = value; }
        }





        /// <summary>
        /// Gets the special instructions for the drink.
        /// </summary>
        public List<string> SpecialInstructions {
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
            return "Markarth Milk";
        }
    }
}
