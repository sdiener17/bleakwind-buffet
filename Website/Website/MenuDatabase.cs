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
                        if ((item.PriceS <= max) || (item.PriceM <= max) || (item.PriceL <= max)) results.Add(item);
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
                        if ((item.PriceS >= min) || (item.PriceM >= min) || (item.PriceL >= min)) results.Add(item);
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
                    if (((item.PriceS >= min) || (item.PriceM >= min) || (item.PriceL >= min)) &&
                        ((item.PriceS <= max) || (item.PriceM <= max) || (item.PriceL <= max))) {
                        results.Add(item);
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
                        if ((item.CaloriesS <= max) || (item.CaloriesM <= max) || (item.CaloriesL <= max)) results.Add(item);
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
                        if ((item.CaloriesS >= min) || (item.CaloriesM >= min) || (item.CaloriesL >= min)) results.Add(item);
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
                    if (((item.CaloriesS >= min) || (item.CaloriesM >= min) || (item.CaloriesL >= min)) &&
                        ((item.CaloriesS <= max) || (item.CaloriesM <= max) || (item.CaloriesL <= max))) {
                        results.Add(item);
                    }
                }
                
            }
            return results;
        }

    }
}
