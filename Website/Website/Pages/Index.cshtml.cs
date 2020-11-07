using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<MenuItem> Menu { get; set; }

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

        public void OnGet(string SearchTerms, string[] MenuTypes, double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax) {
            Menu = MenuDatabase.Search(SearchTerms);
            Menu = MenuDatabase.FilterByMenuType(Menu,MenuTypes);
            Menu = MenuDatabase.FilterByPrice(Menu, PriceMin, PriceMax);
            Menu = MenuDatabase.FilterByCalories(Menu, CaloriesMin, CaloriesMax);
        }


    }
}
