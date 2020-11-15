﻿/*
 * Author: Sarah Diener
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System;

namespace BleakwindBuffet.DataTests.UnitTests {
    public class MenuTests {

        [Fact]
        public void EntreesShouldReturnCorrectList() {
            List<IOrderItem> entrees = new List<IOrderItem>(Menu.Entrees());

            Assert.Collection<IOrderItem>(entrees,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item)
                );

        }



        [Fact]
        public void DrinksShouldReturnCorrectList() {
            List<IOrderItem> drinks = new List<IOrderItem>(Menu.Drinks());

            Assert.Collection<IOrderItem>(drinks,
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Small),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Medium),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Large),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Small),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Medium),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Large),
                item => Assert.True((item as MarkarthMilk).Size == Size.Small),
                item => Assert.True((item as MarkarthMilk).Size == Size.Medium),
                item => Assert.True((item as MarkarthMilk).Size == Size.Large),
                item => Assert.True((item as WarriorWater).Size == Size.Small),
                item => Assert.True((item as WarriorWater).Size == Size.Medium),
                item => Assert.True((item as WarriorWater).Size == Size.Large),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Peach),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon)
                );
        }

        [Fact]
        public void SidesShouldReturnCorrectList() {
            List<IOrderItem> sides = new List<IOrderItem>(Menu.Sides());
            Assert.Collection<IOrderItem>(sides,
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Small),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Medium),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Large),
                item => Assert.True((item as FriedMiraak).Size == Size.Small),
                item => Assert.True((item as FriedMiraak).Size == Size.Medium),
                item => Assert.True((item as FriedMiraak).Size == Size.Large),
                item => Assert.True((item as MadOtarGrits).Size == Size.Small),
                item => Assert.True((item as MadOtarGrits).Size == Size.Medium),
                item => Assert.True((item as MadOtarGrits).Size == Size.Large),
                item => Assert.True((item as VokunSalad).Size == Size.Small),
                item => Assert.True((item as VokunSalad).Size == Size.Medium),
                item => Assert.True((item as VokunSalad).Size == Size.Large)
                
                );
        }

        [Fact]
        public void MenuShouldReturnCorrectList() {
            List<IOrderItem> menu = new List<IOrderItem>(Menu.FullMenu());

            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Small),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Medium),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Large),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Small),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Medium),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Large),
                item => Assert.True((item as MarkarthMilk).Size == Size.Small),
                item => Assert.True((item as MarkarthMilk).Size == Size.Medium),
                item => Assert.True((item as MarkarthMilk).Size == Size.Large),
                item => Assert.True((item as WarriorWater).Size == Size.Small),
                item => Assert.True((item as WarriorWater).Size == Size.Medium),
                item => Assert.True((item as WarriorWater).Size == Size.Large),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Small),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Medium),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Large),
                item => Assert.True((item as FriedMiraak).Size == Size.Small),
                item => Assert.True((item as FriedMiraak).Size == Size.Medium),
                item => Assert.True((item as FriedMiraak).Size == Size.Large),
                item => Assert.True((item as MadOtarGrits).Size == Size.Small),
                item => Assert.True((item as MadOtarGrits).Size == Size.Medium),
                item => Assert.True((item as MadOtarGrits).Size == Size.Large),
                item => Assert.True((item as VokunSalad).Size == Size.Small),
                item => Assert.True((item as VokunSalad).Size == Size.Medium),
                item => Assert.True((item as VokunSalad).Size == Size.Large)
            );
        }


        [Fact]
        public void SearchShouldReturnCorrectItem() {
            string term = "Briarheart Burger";
            IEnumerable<IOrderItem> menu = Menu.Search(term);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item)
                );
            term = "briarheart burger";
            menu = Menu.Search(term);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item)
                );
            term = "sailor soda";
            menu = Menu.Search(term);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Peach),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon)
                );
        }


        [Fact]
        public void FilterByMenuTypeShouldReturnCorrectTypes() {
            List<string> filter = new List<string>();
            filter.Add("Entree");
            IEnumerable<IOrderItem> menu = Menu.FilterByMenuType(Menu.FullMenu(), filter);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item)
                );
            filter.Add("Side");
            menu = Menu.FilterByMenuType(Menu.FullMenu(), filter);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Small),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Medium),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Large),
                item => Assert.True((item as FriedMiraak).Size == Size.Small),
                item => Assert.True((item as FriedMiraak).Size == Size.Medium),
                item => Assert.True((item as FriedMiraak).Size == Size.Large),
                item => Assert.True((item as MadOtarGrits).Size == Size.Small),
                item => Assert.True((item as MadOtarGrits).Size == Size.Medium),
                item => Assert.True((item as MadOtarGrits).Size == Size.Large),
                item => Assert.True((item as VokunSalad).Size == Size.Small),
                item => Assert.True((item as VokunSalad).Size == Size.Medium),
                item => Assert.True((item as VokunSalad).Size == Size.Large)
                );
            

            filter.Clear();
            menu = Menu.FilterByMenuType(Menu.FullMenu(), filter);
            Assert.Collection<IOrderItem>(menu,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Small),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Medium),
                item => Assert.True((item as DragonbornWaffleFries).Size == Size.Large),
                item => Assert.True((item as FriedMiraak).Size == Size.Small),
                item => Assert.True((item as FriedMiraak).Size == Size.Medium),
                item => Assert.True((item as FriedMiraak).Size == Size.Large),
                item => Assert.True((item as MadOtarGrits).Size == Size.Small),
                item => Assert.True((item as MadOtarGrits).Size == Size.Medium),
                item => Assert.True((item as MadOtarGrits).Size == Size.Large),
                item => Assert.True((item as VokunSalad).Size == Size.Small),
                item => Assert.True((item as VokunSalad).Size == Size.Medium),
                item => Assert.True((item as VokunSalad).Size == Size.Large),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Small),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Medium),
                item => Assert.True((item as AretinoAppleJuice).Size == Size.Large),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Small),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Medium),
                item => Assert.True((item as CandlehearthCoffee).Size == Size.Large),
                item => Assert.True((item as MarkarthMilk).Size == Size.Small),
                item => Assert.True((item as MarkarthMilk).Size == Size.Medium),
                item => Assert.True((item as MarkarthMilk).Size == Size.Large),
                item => Assert.True((item as WarriorWater).Size == Size.Small),
                item => Assert.True((item as WarriorWater).Size == Size.Medium),
                item => Assert.True((item as WarriorWater).Size == Size.Large),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Blackberry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Cherry),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Grapefruit),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Lemon),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Peach),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Peach),

                item => Assert.True(((item as SailorSoda).Size == Size.Small) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Medium) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon),
                item => Assert.True(((item as SailorSoda).Size == Size.Large) && (item as SailorSoda).Flavor == SodaFlavor.Watermelon)
                );

        }



        public void FilterByPriceShouldReturnCorrectItems() {

        }



        public void FilterByCaloriesShouldReturnCorrectItems() {

        }
    }
}
