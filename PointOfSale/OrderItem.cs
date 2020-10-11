using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale {
    public class OrderItem : IOrderItem {

        public OrderItem() {

        }

        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;


        public double Price { 
            get; 
        }

        public uint Calories {
            get;
        }

        public List<string> SpecialInstructions {
            get;
        }
    }
}
