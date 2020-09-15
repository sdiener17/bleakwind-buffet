﻿/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldBeADrink() {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(c);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.Equal(Size.Small, c.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = true;
            Assert.True(c.Ice);
            c.Ice = false;
            Assert.False(c.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Decaf = true;
            Assert.True(c.Decaf);
            c.Decaf = false;
            Assert.False(c.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.RoomForCream = true;
            Assert.True(c.RoomForCream);
            c.RoomForCream = false;
            Assert.False(c.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = Size.Large;
            Assert.Equal(Size.Large, c.Size);
            c.Size = Size.Medium;
            Assert.Equal(Size.Medium, c.Size);
            c.Size = Size.Small;
            Assert.Equal(Size.Small, c.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(price, c.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(cal, c.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = includeIce;
            c.RoomForCream = includeCream;
            if ((includeIce) && (includeCream)) {
                Assert.Contains("Add ice", c.SpecialInstructions);
                Assert.Contains("Add cream", c.SpecialInstructions);
            }
            else if ((includeIce)&&(!includeCream)) { 
                Assert.Contains("Add ice", c.SpecialInstructions);
                Assert.DoesNotContain("Add cream", c.SpecialInstructions); 
            }
            else if ((!includeIce) && (includeCream)) { 
                Assert.Contains("Add cream", c.SpecialInstructions);
                Assert.DoesNotContain("Add ice", c.SpecialInstructions);
            }
            else { 
                Assert.Empty(c.SpecialInstructions); 
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Decaf = decaf;
            c.Size = size;
            Assert.Equal(name, c.ToString());
        }
    }
}
