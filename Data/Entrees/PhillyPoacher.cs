/*
* Author: Sarah Diener
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent the Philly Poacher entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class PhillyPoacher : Entree,IOrderItem{

        /// <summary>
        /// Gets the price of the sandwich.
        /// </summary>
        public override double Price {
            get { return 7.23; }
        }

        /// <summary>
        /// Gets the calories of the sandwich.
        /// </summary>
        public override uint Calories {
            get { return 784; }
        }

        /// <summary>
        /// Getter/Setter for if sirloin is wanted.
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin {
            get { return sirloin; }
            set { sirloin = value; }
        }


        /// <summary>
        /// Getter/Setter for if onion is wanted.
        /// </summary>
        private bool onion = true;
        public bool Onion {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Getter/Setter for a roll is wanted.
        /// </summary>
        private bool roll = true;
        public bool Roll {
            get { return roll; }
            set { roll = value; }
        }

       

        /// <summary>
        /// Gets the special instructions for the sandwich (if the customer wants anything to not be included).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!sirloin) { instructions.Add("Hold sirloin"); }
                if (!onion) { instructions.Add("Hold onions"); }
                if (!roll) { instructions.Add("Hold roll"); }
                return instructions;
            }
        }


        public PhillyPoacher() {

        }


        /// <summary>
        /// Returns the name of the sandwich.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Philly Poacher";
        }
    }
}
