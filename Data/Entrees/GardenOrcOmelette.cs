/*
* Author: Sarah Diener
* Class name: GardenOrctOmelette.cs
* Purpose: Class used to represent the Garden Orc Omelette entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class GardenOrcOmelette : Entree,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the description of the entree
        /// </summary>
        public string Description {
            get { return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; }
        }


        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public override double Price {
            get { return 4.57; }
        }

        /// <summary>
        /// Gets the calories of the omelette.
        /// </summary>
        public override uint Calories {
            get { return 404; }
        }

        /// <summary>
        /// Getter/Setter for if broccoli is wanted.
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli {
            get { return broccoli; }
            set { broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Getter/Setter for if mushrooms are wanted.
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms {
            get { return mushrooms; }
            set { mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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
        /// Getter/Setter for if cheddar cheese is wanted.
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar {
            get { return cheddar; }
            set { cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        

        

        /// <summary>
        /// Gets the special instructions for the omelette (if the customer wants anything to not be included).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!broccoli) { instructions.Add("Hold broccoli"); }
                if (!mushrooms) { instructions.Add("Hold mushrooms"); }
                if (!tomato) { instructions.Add("Hold tomato"); }
                if (!cheddar) { instructions.Add("Hold cheddar"); }
                return instructions;
            }
        }


        public GardenOrcOmelette() {

        }


        /// <summary>
        /// Returns the name of the omelette.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Garden Orc Omelette";
        }
    }
}
