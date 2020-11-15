/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {

        [Fact]
        public void ShouldReturnCorrectDescription() {
            BriarheartBurger f = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", f.Description);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = false;
            });
            Assert.PropertyChanged(b, "Bun", () =>
             {
                 b.Bun = true;
             });
        }


        [Fact]
        public void ChangingKetchupNotifiesBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = false;
            });
            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = true;
            });
        }


        [Fact]
        public void ChangingMustardNotifiesBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = false;
            });
            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = true;
            });
        }


        [Fact]
        public void ChangingCheeseNotifiesBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = false;
            });
            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = true;
            });
        }


        [Fact]
        public void ChangingPicklesNotifiesBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = false;
            });
            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = true;
            });
        }


        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(b);
        }

        [Fact]
        public void ShouldBeAnEntree() {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = false;
            Assert.False(b.Bun);
            b.Bun = true;
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = false;
            Assert.False(b.Ketchup);
            b.Ketchup = true;
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = false;
            Assert.False(b.Mustard);
            b.Mustard = true;
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = false;
            Assert.False(b.Pickle);
            b.Pickle = true;
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = false;
            Assert.False(b.Cheese);
            b.Cheese = true;
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("743", b.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            b.Ketchup = includeKetchup;
            b.Mustard = includeMustard;
            b.Pickle = includePickle;
            b.Cheese = includeCheese;
            if (!includeBun) { Assert.Contains("Hold bun", b.SpecialInstructions); }
            if (!includeKetchup) { Assert.Contains("Hold ketchup", b.SpecialInstructions); }
            if (!includeMustard) { Assert.Contains("Hold mustard", b.SpecialInstructions); }
            if (!includePickle) { Assert.Contains("Hold pickle", b.SpecialInstructions); }
            if (!includeCheese) { Assert.Contains("Hold cheese", b.SpecialInstructions); }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) { Assert.Empty(b.SpecialInstructions); }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }
    }
}