using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Website {
    /// <summary>
    /// A class representing a database of menu items
    /// </summary>
    public class MenuDatabase {

        private static List<MenuItem> menu = new List<MenuItem>();

        /// <summary>
        /// Loads the menu items from the json file
        /// </summary>
        static MenuDatabase() {

            using (StreamReader file = System.IO.File.OpenText("menuItems.json")) {
                string json = file.ReadToEnd();
                menu = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            }
        }

        /// <summary>
        /// Gets all the menu items in the database
        /// </summary>
        public static IEnumerable<MenuItem> All { get { return menu; } }


        /// <summary>
        /// Gets the possible Menu types
        /// </summary>
        public static string[] MenuTypes {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }


        /// <summary>
        /// Gets all the menu items containing the search term
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<MenuItem> Search(string terms) {
            List<MenuItem> results = new List<MenuItem>();

            //null check
            if (terms == null) {
                return All;
            }
            //Adds the movie if the title is a match
            foreach (MenuItem item in All) {
                if (item.Name != null && item.Name.Contains(terms, StringComparison.CurrentCultureIgnoreCase)) {
                    results.Add(item);
                }
            }
            return results;
        }


        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="menuitems">The collection of menu items to filter</param>
        /// <param name="filter">The menu items to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<MenuItem> FilterByMenuType(IEnumerable<MenuItem> menuitems, IEnumerable<string> filter) {

            // If no filter is specified, just return the provided collection
            if (filter == null || filter.Count() == 0) {
                
                return menuitems;
            }

            // Filter the supplied collection of movies
            List<MenuItem> results = new List<MenuItem>();
            foreach (MenuItem item in menuitems) {
                if (item.Type != null && filter.Contains(item.Type)) {
                    
                    results.Add(item);
                }
            }
            return results;
        }



        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with price falling within
        /// the specified range
        /// </summary>
        /// <param name="menuitems">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<MenuItem> FilterByPrice(IEnumerable<MenuItem> menuItems, double? min, double? max) {
            var results = new List<MenuItem>();
            
            //No values specified
            if (min == null && max == null) {
                return menuItems;
            }
            // only a maximum specified
            if (min == null) {
                foreach (MenuItem item in menuItems) {
                    if (item.Type.Equals("Entree")) {
                        if ((item.PriceS <= max)) results.Add(item);
                    }
                    else {
                        if (item.PriceS <= max) {
                            item.PriceSDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceSDisplay = false;
                        }
                        if (item.PriceM <= max) {
                            item.PriceMDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceMDisplay = false;
                        }
                        if (item.PriceL <= max) {
                            item.PriceLDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceLDisplay = false;
                        }
                    }
                    
                }
                return results;
            }

            // only a minimum specified
            if (max == null) {
                foreach (MenuItem item in menuItems) {
                    if (item.Type.Equals("Entree")) {
                        if ((item.PriceS >= min)) results.Add(item);
                    }
                    else {
                        if (item.PriceS >= min) {
                            item.PriceSDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceSDisplay = false;
                        }
                        if (item.PriceM >= min) {
                            item.PriceMDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceMDisplay = false;
                        }
                        if(item.PriceL >= min) {
                            item.PriceLDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.PriceLDisplay = false;
                        }
                    }
                    
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (MenuItem item in menuItems) {
                if (item.Type.Equals("Entree")) {
                    if ((item.PriceS <= max) && (item.PriceS >= min)) {
                        results.Add(item);
                    }
                }
                else {
                    if ((item.PriceS >= min) && item.PriceS <= max) {
                        item.PriceSDisplay = true;
                        if(!results.Contains(item)) results.Add(item);

                    }
                    else {
                        item.PriceSDisplay = false;
                    }
                    if ((item.PriceM >= min) && (item.PriceM <= max)) {
                        item.PriceMDisplay = true;
                        if (!results.Contains(item)) results.Add(item);
                    }
                    else {
                        item.PriceMDisplay = false;
                    }
                    if ((item.PriceL >= min) && (item.PriceL <= max)) {
                        item.PriceLDisplay = true;
                        if (!results.Contains(item)) results.Add(item);
                    }
                    else {
                        item.PriceLDisplay = false;
                    }
                }
            }
            return results;
        }



        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with calories falling within
        /// the specified range
        /// </summary>
        /// <param name="menuitems">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<MenuItem> FilterByCalories(IEnumerable<MenuItem> menuItems, double? min, double? max) {
            var results = new List<MenuItem>();

            //No values specified
            if (min == null && max == null) {
                return menuItems;
            }
            // only a maximum specified
            if (min == null) {
                foreach (MenuItem item in menuItems) {
                    if (item.Type.Equals("Entree")) {
                        if ((item.CaloriesS <= max)) results.Add(item);
                    }
                    else {
                        if (item.CaloriesS <= max) {
                            item.CaloriesSDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesSDisplay = false;
                        }
                        if (item.CaloriesM <= max) {
                            item.CaloriesMDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesMDisplay = false;
                        }
                        if (item.CaloriesL <= max) {
                            item.CaloriesLDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesLDisplay = false;
                        }
                    }

                }
                return results;
            }

            // only a minimum specified
            if (max == null) {
                foreach (MenuItem item in menuItems) {
                    if (item.Type.Equals("Entree")) {
                        if (item.CaloriesS >= min) results.Add(item);
                    }
                    else {
                        if (item.CaloriesS >= min) {
                            item.CaloriesSDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesSDisplay = false;
                        }
                        if (item.CaloriesM >= min) {
                            item.CaloriesMDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesMDisplay = false;
                        }
                        if (item.CaloriesL >= min) {
                            item.CaloriesLDisplay = true;
                            if (!results.Contains(item)) results.Add(item);
                        }
                        else {
                            item.CaloriesLDisplay = false;
                        }
                    }
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (MenuItem item in menuItems) {
                if (item.Type.Equals("Entree")) {
                    if ((item.CaloriesS <= max) && (item.CaloriesS >= min)) {
                        results.Add(item);
                    }
                }
                else {
                    if ((item.CaloriesS >= min) && item.CaloriesS <= max) {
                        item.CaloriesSDisplay = true;
                        if (!results.Contains(item)) results.Add(item);

                    }
                    else {
                        item.CaloriesSDisplay = false;
                    }
                    if ((item.CaloriesM >= min) && (item.CaloriesM <= max)) {
                        item.CaloriesMDisplay = true;
                        if (!results.Contains(item)) results.Add(item);
                    }
                    else {
                        item.CaloriesMDisplay = false;
                    }
                    if ((item.CaloriesL >= min) && (item.CaloriesL <= max)) {
                        item.CaloriesLDisplay = true;
                        if (!results.Contains(item)) results.Add(item);
                    }
                    else {
                        item.CaloriesLDisplay = false;
                    }
                }
                
            }
            return results;
        }

    }
}
