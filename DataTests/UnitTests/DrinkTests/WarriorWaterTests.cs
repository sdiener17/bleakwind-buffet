/*
 * Author: Sarah Diener
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests {
    public class WarriorWaterTests {

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            WarriorWater x = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }


        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            WarriorWater x = new WarriorWater();
            Assert.PropertyChanged(x, "Medium", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Large", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Small", () =>
            {
                x.Size = Size.Small;
            });
        }


        [Fact]
        public void ChangingIceNotifiesProperty()
        {
            WarriorWater x = new WarriorWater();
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = false;
            });
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = true;
            });
        }


        [Fact]
        public void ChangingLemonNotifiesProperty()
        {
            WarriorWater x = new WarriorWater();
            Assert.PropertyChanged(x, "Lemon", () =>
            {
                x.Lemon = false;
            });
            Assert.PropertyChanged(x, "Lemon", () =>
            {
                x.Lemon = true;
            });
        }



        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(w);
        }

        [Fact]
        public void ShouldBeADrink() {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }

        [Fact]
        public void ShouldIncludeIceByDefault() {
            WarriorWater w = new WarriorWater();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault() {
            WarriorWater w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault() {
            WarriorWater w = new WarriorWater();
            Assert.False(w.Lemon);
        }


        [Fact]
        public void ShouldBeAbleToSetIce() {
            WarriorWater w = new WarriorWater();
            w.Ice = false;
            Assert.False(w.Ice);
            w.Ice = true;
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon() {
            WarriorWater w = new WarriorWater();
            w.Lemon = true;
            Assert.True(w.Lemon);
            w.Lemon = false;
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            WarriorWater w = new WarriorWater();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Small;
            Assert.Equal(Size.Small, w.Size);
        }


        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price) {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(price, w.Price);
        }

        [Fact]
        public void ShouldAlwaysHaveZeroCalories() {
            WarriorWater w = new WarriorWater();
            Assert.Equal("0", w.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon) {
            WarriorWater w = new WarriorWater();
            w.Ice = includeIce;
            w.Lemon = includeLemon;
            if ((includeIce) && (includeLemon)) {
                //Assert.Contains("Add ice", w.SpecialInstructions);
                Assert.Contains("Add lemon", w.SpecialInstructions);
            }
            else if ((includeIce) && (!includeLemon)) {
                Assert.Empty(w.SpecialInstructions);
            }
            else if ((!includeIce) && (includeLemon)) {
                Assert.Contains("Hold ice", w.SpecialInstructions);
                Assert.Contains("Add lemon", w.SpecialInstructions);
            }
            else {
                Assert.Contains("Hold ice", w.SpecialInstructions);
            }
        }



        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name) {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(name, w.ToString());
        }


    }
}
