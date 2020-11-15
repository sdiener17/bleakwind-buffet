using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> IndexMenu { get; set; }

        /// <summary>
        /// The menu items to filter
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The menu types to filter
        /// </summary>
        public string[] MenuTypes { get; set; }

        /// <summary>
        /// The min price to filter
        /// </summary>
        public double PriceMin { get; set; }

        /// <summary>
        /// The max price to filter
        /// </summary>
        public double PriceMax { get; set; }

        
        /// <summary>
        /// The min calories to filter
        /// </summary>
        public int CaloriesMin { get; set; }


        /// <summary>
        /// The max calories to filter
        /// </summary>
        public int CaloriesMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, List<string>? MenuTypes, double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax) {
            IndexMenu = Menu.FullMenu();
            if (SearchTerms != null) {
                IndexMenu = from item in IndexMenu
                         where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                         select item;
            }
            if (MenuTypes != null && MenuTypes.Count !=0) {
                IndexMenu = from item in IndexMenu
                         where (item is BleakwindBuffet.Data.Entrees.Entree && MenuTypes.Contains("Entree")) ||
                            (item is BleakwindBuffet.Data.Sides.Side && MenuTypes.Contains("Side")) ||
                            (item is BleakwindBuffet.Data.Drinks.Drink && MenuTypes.Contains("Drink"))
                         select item;
            }
            //Only a max specified
            if (PriceMin == null && PriceMax != null) {
                IndexMenu = from item in IndexMenu
                         where item.Price != null && item.Price <= PriceMax
                         select item;
            }
            //Only a min specified
            if (PriceMin != null && PriceMax == null) {
                IndexMenu = from item in IndexMenu
                         where item.Price != null && item.Price >= PriceMin
                         select item;
            }
            if (PriceMin != null && PriceMax != null) {
                IndexMenu = from item in IndexMenu
                         where item.Price != null && item.Price <= PriceMax && item.Price >= PriceMin
                         select item;
            }
            //Only a max specified
            if (CaloriesMin == null && CaloriesMax != null) {
                IndexMenu = from item in IndexMenu
                            where item.Calories != null && item.Calories <= CaloriesMax
                            select item;
            }
            //Only a min specified
            if (CaloriesMin != null && CaloriesMax == null) {
                IndexMenu = from item in IndexMenu
                            where item.Calories != null && item.Calories >= CaloriesMin
                            select item;
            }
            if (CaloriesMin != null && CaloriesMax != null) {
                IndexMenu = from item in IndexMenu
                            where item.Calories != null && item.Calories <= CaloriesMax && item.Calories >= CaloriesMin
                            select item;
            }
            //IndexMenu = Menu.Search(SearchTerms);
            //IndexMenu = Menu.FilterByMenuType(IndexMenu, MenuTypes);
            //IndexMenu = Menu.FilterByPrice(IndexMenu, PriceMin, PriceMax);
            //IndexMenu = Menu.FilterByCalories(IndexMenu, CaloriesMin, CaloriesMax);
        }


    }
}
