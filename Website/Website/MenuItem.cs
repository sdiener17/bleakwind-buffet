﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website {
    /// <summary>
    /// A class representing a menu item
    /// </summary>
    public class MenuItem {

        /// <summary>
        /// Gets or sets the type of menu item
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the menu item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price of an entree or small side or drink
        /// </summary>
        public double PriceS { get; set; }

        /// <summary>
        /// Gets or sets the calories of an entree or small side or drink
        /// </summary>
        public uint CaloriesS { get; set; }

        /// <summary>
        /// Gets or sets the price of a medium side or drink
        /// </summary>
        public double PriceM { get; set; }

        /// <summary>
        /// Gets or sets the price of a large side or drink
        /// </summary>
        public double PriceL { get; set; }

        /// <summary>
        /// Gets or sets the calories of a medium side or drink
        /// </summary>
        public uint CaloriesM { get; set; }

        /// <summary>
        /// Gets or sets the calories of a large side or drink
        /// </summary>
        public uint CaloriesL { get; set; }
    }
}
