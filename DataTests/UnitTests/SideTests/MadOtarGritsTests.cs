/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Security.Cryptography;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            MadOtarGrits x = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }

        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            MadOtarGrits x = new MadOtarGrits();
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
        public void ShouldBeAssignableToIOrderItem() {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        [Fact]
        public void ShouldBeASide() {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(m);
        }


        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(price, mo.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(name, mo.ToString());
        }
    }
}