/*
* Author: Sarah Diener
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent the Smokehouse Skeleton entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree {
    class SmokehouseSkeleton {

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price {
            get { return 5.62; }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories {
            get { return 602; }
        }

        /// <summary>
        /// Getter/Setter for if a sausagelinks are wanted.
        /// </summary>
        private bool sausagelink = true;
        public bool SausageLink {
            get { return sausagelink; }
            set { sausagelink = value; }
        }


        /// <summary>
        /// Getter/Setter for if eggs are wanted.
        /// </summary>
        private bool egg = true;
        public bool Egg {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Getter/Setter for if hashbrowns are wanted.
        /// </summary>
        private bool hashbrowns = true;
        public bool Hashbrowns {
            get { return hashbrowns; }
            set { hashbrowns = value; }
        }

        /// <summary>
        /// Getter/Setter for if pancakes are wanted.
        /// </summary>
        private bool pancake = true;
        public bool Pancake {
            get { return pancake; }
            set { pancake = value; }
        }




        /// <summary>
        /// Gets the special instructions for the combo (if the customer wants anything to not be included).
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!sausagelink) { instructions.Add("Hold sausage"); }
                if (!egg) { instructions.Add("Hold eggs"); }
                if (!hashbrowns) { instructions.Add("Hold hash browns"); }
                if (!pancake) { instructions.Add("Hold pancakes"); }
                return instructions;
            }
        }


        public SmokehouseSkeleton() {

        }


        /// <summary>
        /// Returns the name of the combo.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Smokehouse Skeleton";
        }
    }
}
