/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {


        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            FriedMiraak x = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }


        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            FriedMiraak x = new FriedMiraak();
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Size", () =>
            {
                x.Size = Size.Small;
            });
        }


        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(f);
        }

        [Fact]
        public void ShouldBeASide() {
            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(f);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Equal(Size.Small, f.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = Size.Large;
            Assert.Equal(Size.Large, f.Size);
            f.Size = Size.Medium;
            Assert.Equal(Size.Medium, f.Size);
            f.Size = Size.Small;
            Assert.Equal(Size.Small, f.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Empty(f.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(price, f.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(calories, f.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(name, f.ToString());
        }
    }
}