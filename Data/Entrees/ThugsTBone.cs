/*
* Author: Sarah Diener
* Class name: ThugsTBone.cs
* Purpose: Class used to represent the Thugs T-Bone entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class ThugsTBone : Entree,IOrderItem,INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the T-Bone.
        /// </summary>
        public override double Price {
            get { return 6.44; }
        }

        /// <summary>
        /// Gets the calories of the T-Bone.
        /// </summary>
        public override uint Calories {
            get { return 982; }
        }

      
        /// <summary>
        /// Gets the special instructions for the T-Bone.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        public ThugsTBone() {

        }


        /// <summary>
        /// Returns the name of the T-Bone.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Thugs T-Bone";
        }
    }
}
