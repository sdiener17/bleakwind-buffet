/*
* Author: Sarah Diener
* Class name: IOrderItem.cs
* Purpose: Interface with properties shared by all menu items
*/
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data {
    public interface IOrderItem {

        /// <summary>
        /// Gets the price of the item.
        /// </summary>
        double Price { get; }


        /// <summary>
        /// Gets the calories of the item.
        /// </summary>
        uint Calories { get; }



        /// <summary>
        /// Gets the special instructions of the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
