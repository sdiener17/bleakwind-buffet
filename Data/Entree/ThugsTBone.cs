using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree {
    class ThugsTBone {

        /// <summary>
        /// Gets the price of the T-Bone.
        /// </summary>
        public double Price {
            get { return 6.44; }
        }

        /// <summary>
        /// Gets the calories of the T-Bone.
        /// </summary>
        public uint Calories {
            get { return 982; }
        }

      
        /// <summary>
        /// Gets the special instructions for the T-Bone.
        /// </summary>
        public List<string> SpecialInstructions {
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
