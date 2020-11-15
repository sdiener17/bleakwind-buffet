/*
* Author: Sarah Diener
* Class name: Menu.cs
* Purpose: Static class used to create separate lists of the entree, side, and drink items and a list of all menu items.
*/
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data {

    /// <summary>
    /// A class representing a menu.
    /// </summary>
    public static class Menu {

      

        /// <summary>
        /// Creates a list of all entree food items on the menu.
        /// </summary>
        /// <returns>A list of the entrees on the menu</returns>
        public static IEnumerable<IOrderItem> Entrees() {
            List<IOrderItem> entrees = new List<IOrderItem>();
            BriarheartBurger b = new BriarheartBurger();
            DoubleDraugr d = new DoubleDraugr();
            GardenOrcOmelette go = new GardenOrcOmelette();
            PhillyPoacher p = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tha = new ThalmorTriple();
            ThugsTBone thu = new ThugsTBone();
            entrees.Add(b);
            entrees.Add(d);
            entrees.Add(go);
            entrees.Add(p);
            entrees.Add(ss);
            entrees.Add(tha);
            entrees.Add(thu);
            return entrees;
        }


        /// <summary>
        /// Creates a list of all the drink items on the menu.
        /// </summary>
        /// <returns>A list of the drinks on the menu.</returns>
        public static IEnumerable<IOrderItem> Drinks() {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice ajs = new AretinoAppleJuice();
            AretinoAppleJuice ajm = new AretinoAppleJuice();
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajs.Size = Size.Small;
            ajm.Size = Size.Medium;
            ajl.Size = Size.Large;

            CandlehearthCoffee cs = new CandlehearthCoffee();
            CandlehearthCoffee cm = new CandlehearthCoffee();
            CandlehearthCoffee cl = new CandlehearthCoffee();
            cs.Size = Size.Small;
            cm.Size = Size.Medium;
            cl.Size = Size.Large;

            MarkarthMilk ms = new MarkarthMilk();
            MarkarthMilk mm = new MarkarthMilk();
            MarkarthMilk ml = new MarkarthMilk();
            ms.Size = Size.Small;
            mm.Size = Size.Medium;
            ml.Size = Size.Large;

            WarriorWater ws = new WarriorWater();
            WarriorWater wm = new WarriorWater();
            WarriorWater wl = new WarriorWater();
            ws.Size = Size.Small;
            wm.Size = Size.Medium;
            wl.Size = Size.Large;

            SailorSoda sbs = new SailorSoda();
            SailorSoda scs = new SailorSoda();
            SailorSoda sgs = new SailorSoda();
            SailorSoda sls = new SailorSoda();
            SailorSoda sps = new SailorSoda();
            SailorSoda sws = new SailorSoda();
            SailorSoda sbm = new SailorSoda();
            SailorSoda scm = new SailorSoda();
            SailorSoda sgm = new SailorSoda();
            SailorSoda slm = new SailorSoda();
            SailorSoda spm = new SailorSoda();
            SailorSoda swm = new SailorSoda();
            SailorSoda sbl = new SailorSoda();
            SailorSoda scl = new SailorSoda();
            SailorSoda sgl = new SailorSoda();
            SailorSoda sll = new SailorSoda();
            SailorSoda spl = new SailorSoda();
            SailorSoda swl = new SailorSoda();
            sbs.Size = Size.Small;
            scs.Size = Size.Small;
            sgs.Size = Size.Small;
            sls.Size = Size.Small;
            sps.Size = Size.Small;
            sws.Size = Size.Small;
            sbm.Size = Size.Medium;
            scm.Size = Size.Medium;  
            sgm.Size = Size.Medium;
            slm.Size = Size.Medium;
            spm.Size = Size.Medium;
            swm.Size = Size.Medium;
            sbl.Size = Size.Large;
            scl.Size = Size.Large;
            sgl.Size = Size.Large;
            sll.Size = Size.Large;
            spl.Size = Size.Large;
            swl.Size = Size.Large;
            sbs.Flavor = SodaFlavor.Blackberry;
            sbm.Flavor = SodaFlavor.Blackberry;
            sbl.Flavor = SodaFlavor.Blackberry;
            scs.Flavor = SodaFlavor.Cherry;
            scm.Flavor = SodaFlavor.Cherry;
            scl.Flavor = SodaFlavor.Cherry;
            sgs.Flavor = SodaFlavor.Grapefruit;
            sgm.Flavor = SodaFlavor.Grapefruit;
            sgl.Flavor = SodaFlavor.Grapefruit;
            sls.Flavor = SodaFlavor.Lemon;
            slm.Flavor = SodaFlavor.Lemon;
            sll.Flavor = SodaFlavor.Lemon;
            sps.Flavor = SodaFlavor.Peach;
            spm.Flavor = SodaFlavor.Peach;
            spl.Flavor = SodaFlavor.Peach;
            sws.Flavor = SodaFlavor.Watermelon;
            swm.Flavor = SodaFlavor.Watermelon;
            swl.Flavor = SodaFlavor.Watermelon;

            drinks.Add(ajs);
            drinks.Add(ajm);
            drinks.Add(ajl);
            drinks.Add(cs);
            drinks.Add(cm);
            drinks.Add(cl);
            drinks.Add(ms);
            drinks.Add(mm);
            drinks.Add(ml);
            drinks.Add(ws);
            drinks.Add(wm);
            drinks.Add(wl);
            drinks.Add(sbs);
            drinks.Add(sbm);
            drinks.Add(sbl);
            drinks.Add(scs);
            drinks.Add(scm);
            drinks.Add(scl);
            drinks.Add(sgs);
            drinks.Add(sgm);
            drinks.Add(sgl);
            drinks.Add(sls);
            drinks.Add(slm);
            drinks.Add(sll);
            drinks.Add(sps);
            drinks.Add(spm);
            drinks.Add(spl);
            drinks.Add(sws);
            drinks.Add(swm);
            drinks.Add(swl);
            

            return drinks;
        }



        /// <summary>
        /// Creates a list of all the side items on the menu.
        /// </summary>
        /// <returns>A list of the sides on the menu.</returns>
        public static IEnumerable<IOrderItem> Sides() {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries ds = new DragonbornWaffleFries();
            DragonbornWaffleFries dm = new DragonbornWaffleFries();
            DragonbornWaffleFries dl = new DragonbornWaffleFries();
            ds.Size = Size.Small;
            dm.Size = Size.Medium;
            dl.Size = Size.Large;

            FriedMiraak fs = new FriedMiraak();
            FriedMiraak fm = new FriedMiraak();
            FriedMiraak fl = new FriedMiraak();
            fs.Size = Size.Small;
            fm.Size = Size.Medium;
            fl.Size = Size.Large;

            MadOtarGrits mos = new MadOtarGrits();
            MadOtarGrits mom = new MadOtarGrits();
            MadOtarGrits mol = new MadOtarGrits();
            mos.Size = Size.Small;
            mom.Size = Size.Medium;
            mol.Size = Size.Large;

            VokunSalad vs = new VokunSalad();
            VokunSalad vm = new VokunSalad();
            VokunSalad vl = new VokunSalad();
            vs.Size = Size.Small;
            vm.Size = Size.Medium;
            vl.Size = Size.Large;

            sides.Add(ds);
            sides.Add(dm);
            sides.Add(dl);
            sides.Add(fs);
            sides.Add(fm);
            sides.Add(fl);
            sides.Add(mos);
            sides.Add(mom);
            sides.Add(mol);
            sides.Add(vs);
            sides.Add(vm);
            sides.Add(vl);
            return sides;
        }


        /// <summary>
        /// Creates a list of all the menu items.
        /// </summary>
        /// <returns>A list of all the menu items.</returns>
        public static IEnumerable<IOrderItem> FullMenu() {
            List<IOrderItem> menu = new List<IOrderItem>();

            List<IOrderItem> entrees = new List<IOrderItem>(Entrees());
            foreach(IOrderItem entree in entrees) {
                menu.Add(entree);
            }
            List<IOrderItem> drinks = new List<IOrderItem>(Drinks());
            foreach(IOrderItem drink in drinks) {
                menu.Add(drink);
            }
            List<IOrderItem> sides = new List<IOrderItem>(Sides());
            foreach(IOrderItem side in sides) {
                menu.Add(side);
            }

            return menu;
        }



        /// <summary>
        /// Gets all the menu items containing the search term
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms) {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null) {
                return FullMenu();
            }
            //Adds the movie if the title is a match
            foreach (IOrderItem item in FullMenu()) {
                if (item.ToString() != null && item.ToString().ToLower().Contains(terms.ToLower())) {
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
        public static IEnumerable<IOrderItem> FilterByMenuType(IEnumerable<IOrderItem> menuitems, List<string> filter) {

            // If no filter is specified, just return the provided collection
            if (filter == null || filter.Count==0) {

                return menuitems;
            }

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in menuitems) {
                if (filter.Contains("Entree") && item is Entree) {
                    results.Add(item);
                }
                if (filter.Contains("Side") && item is Side) {
                    results.Add(item);
                }
                if (filter.Contains("Drink") && item is Drink) {
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
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuItems, double? min, double? max) {
            var results = new List<IOrderItem>();

            //No values specified
            if (min == null && max == null) {
                return menuItems;
            }
            // only a maximum specified
            if (min == null) {
                foreach (IOrderItem item in menuItems) {
                        if ((item.Price <= max)) results.Add(item);
                    }
                return results;
            }
            // only a minimum specified
            if (max == null) {
                foreach (IOrderItem item in menuItems) {
                        if ((item.Price >= min)) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in menuItems) {
                    if ((item.Price <= max) && (item.Price >= min)) {
                        results.Add(item);
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
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuItems, double? min, double? max) {
            var results = new List<IOrderItem>();

            //No values specified
            if (min == null && max == null) {
                return menuItems;
            }
            // only a maximum specified
            if (min == null) {
                foreach (IOrderItem item in menuItems) {
                    if ((item.Calories <= max)) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null) {
                foreach (IOrderItem item in menuItems) {
                    if ((item.Calories >= min)) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in menuItems) {
                if ((item.Calories <= max) && (item.Calories >= min)) {
                    results.Add(item);
                }
            }
            return results;

        }

    }//end class
}
