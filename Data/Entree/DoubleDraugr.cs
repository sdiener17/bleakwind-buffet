using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree {
    class DoubleDraugr {

        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price {
            get { return 7.32; }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories {
            get { return 843; }
        }

        /// <summary>
        /// Getter/Setter for if a bun is wanted.
        /// </summary>
        private bool bun = true;
        public bool Bun {
            get { return bun; }
            set { bun = value; }
        }


        /// <summary>
        /// Getter/Setter for if ketchup is wanted.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Getter/Setter for if mustard is wanted.
        /// </summary>
        private bool mustard = true;
        public bool Mustard {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Getter/Setter for if cheese is wanted.
        /// </summary>
        private bool cheese = true;
        public bool Cheese {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Getter/Setter for if pickles are wanted.
        /// </summary>
        private bool pickle = true;
        public bool Pickle {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Getter/Setter for if tomato is wanted.
        /// </summary>
        private bool tomato = true;
        public bool Tomato {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Getter/Setter for if lettuce is wanted.
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// Getter/Setter for if mayo is wanted.
        /// </summary>
        private bool mayo = true;
        public bool Mayo {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Gets the special instructions for the burger (if the customer wants anything to not be included).
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!bun) { instructions.Add("Hold bun"); }
                if (!ketchup) { instructions.Add("Hold ketchup"); }
                if (!mustard) { instructions.Add("Hold mustard"); }
                if (!cheese) { instructions.Add("Hold cheese"); }
                if (!pickle) { instructions.Add("Hold pickle"); }
                if (!tomato) { instructions.Add("Hold tomato"); }
                if (!lettuce) { instructions.Add("Hold lettuce"); }
                if(!mayo) { instructions.Add("Hold mayo"); }
                return instructions;
            }
        }


        public DoubleDraugr() {

        }


        /// <summary>
        /// Returns the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Double Draugr";
        }
    }
}
