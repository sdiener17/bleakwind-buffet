/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldReturnCorrectDescription() {
            MarkarthMilk f = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", f.Description);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            MarkarthMilk x = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }

        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            MarkarthMilk x = new MarkarthMilk();
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
            MarkarthMilk x = new MarkarthMilk();
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = true;
            });
            Assert.PropertyChanged(x, "Ice", () =>
            {
                x.Ice = false;
            });
        }


        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        [Fact]
        public void ShouldBeADrink() {
            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.Equal(Size.Small, m.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = true;
            Assert.True(m.Ice);
            m.Ice = false;
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(cal, m.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = includeIce;
            if (includeIce) { Assert.Contains("Add ice", m.SpecialInstructions); }
            else { Assert.Empty(m.SpecialInstructions); }
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }
    }
}