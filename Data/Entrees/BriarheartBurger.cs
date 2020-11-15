/*
* Author: Sarah Diener
* Class name: BriarheartBurger.cs
* Purpose: Class used to represent the Briarheart burger entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class BriarheartBurger : Entree,IOrderItem, INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the entree
        /// </summary>
        public string Description {
            get { return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; }
        }


        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price {
            get{ return 6.32; }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories {
            get{ return 743; }
        }

        /// <summary>
        /// Getter/Setter for if a bun is wanted.
        /// </summary>
        private bool bun = true;
        public bool Bun {
            get { return bun; }
            set { 
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Getter/Setter for if ketchup is wanted.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup {
            get{ return ketchup; }
            set{ 
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }

        /// <summary>
        /// Getter/Setter for if mustard is wanted.
        /// </summary>
        private bool mustard = true;
        public bool Mustard {
            get { return mustard; }
            set { 
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if cheese is wanted.
        /// </summary>
        private bool cheese = true;
        public bool Cheese {
            get { return cheese; }
            set { 
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if pickles are wanted.
        /// </summary>
        private bool pickle = true;
        public bool Pickle {
            get { return pickle; }
            set { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the special instructions for the burger (if the customer wants anything to not be included).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if(!bun) { instructions.Add("Hold bun"); }
                if(!ketchup) { instructions.Add("Hold ketchup"); }
                if(!mustard) { instructions.Add("Hold mustard"); }
                if(!cheese) { instructions.Add("Hold cheese"); }
                if(!pickle) { instructions.Add("Hold pickle"); }
                return instructions;
            }
        }


        public BriarheartBurger() {

        }


        /// <summary>
        /// Returns the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Briarheart Burger";
        }

    }// End class
}
