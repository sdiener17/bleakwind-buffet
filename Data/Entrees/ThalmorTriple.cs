/*
* Author: Sarah Diener
* Class name: ThalmorTriple.cs
* Purpose: Class used to represent the Thalmor Triple entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class ThalmorTriple : Entree,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the entree
        /// </summary>
        public string Description {
            get { return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }
        }


        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price {
            get { return 8.32; }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories {
            get { return 943; }
        }

        /// <summary>
        /// Getter/Setter for if a bun is wanted.
        /// </summary>
        private bool bun = true;
        public bool Bun {
            get { return bun; }
            set { bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Getter/Setter for if ketchup is wanted.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup {
            get { return ketchup; }
            set { ketchup = value;
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
            set { mustard = value;
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
            set { cheese = value;
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
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if tomato is wanted.
        /// </summary>
        private bool tomato = true;
        public bool Tomato {
            get { return tomato; }
            set { tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if lettuce is wanted.
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce {
            get { return lettuce; }
            set { lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if mayo is wanted.
        /// </summary>
        private bool mayo = true;
        public bool Mayo {
            get { return mayo; }
            set { mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if bacon is wanted.
        /// </summary>
        private bool bacon = true;
        public bool Bacon {
            get { return bacon; }
            set { bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Getter/Setter for if egg is wanted.
        /// </summary>
        private bool egg = true;
        public bool Egg {
            get { return egg; }
            set { egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the special instructions for the burger (if the customer wants anything to not be included).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!bun) { instructions.Add("Hold bun"); }
                if (!ketchup) { instructions.Add("Hold ketchup"); }
                if (!mustard) { instructions.Add("Hold mustard"); }
                if (!cheese) { instructions.Add("Hold cheese"); }
                if (!pickle) { instructions.Add("Hold pickle"); }
                if (!tomato) { instructions.Add("Hold tomato"); }
                if (!lettuce) { instructions.Add("Hold lettuce"); }
                if (!mayo) { instructions.Add("Hold mayo"); }
                if (!bacon) { instructions.Add("Hold bacon"); }
                if (!egg) { instructions.Add("Hold egg"); }
                return instructions;
            }
        }


        public ThalmorTriple() {

        }


        /// <summary>
        /// Returns the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Thalmor Triple";
        }
    }
}
