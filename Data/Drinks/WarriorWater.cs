﻿/*
* Author: Sarah Diener
* Class name: WarriorWater.cs
* Purpose: Class used to represent the Warrior Water drink
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks {
    public class WarriorWater : Drink, IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the description of the item
        /// </summary>
        public string Description {
            get { return "It’s water. Just water."; }
        }



        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                return 0.00;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories {
            get {
                return 0;
            }
        }

        /// <summary>
        /// Getter/Setter for the size of drink.
        /// </summary>
        private Size size = Size.Small;
        public override Size Size {
            get {
                return size;
            }
            set {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(size.ToString()));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Price.ToString()));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Calories.ToString()));
              
            }
        }

        /// <summary>
        /// Getter/Setter for if ice is wanted.
        /// </summary>
        private bool ice = true;
        public bool Ice {
            get { return ice; }
            set { ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }

        /// <summary>
        /// Getter/Setter for is lemon is wanted.
        /// </summary>
        private bool lemon = false;
        public bool Lemon {
            get{ return lemon; }
            set { lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Gets the special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!ice) { instructions.Add("Hold ice"); }
                if (lemon) { instructions.Add("Add lemon"); }
                return instructions;
            }
        }


        public WarriorWater() {

        }


        /// <summary>
        /// Returns the name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size.ToString() + " Warrior Water";
        }
    }
}
