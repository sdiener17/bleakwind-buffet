/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldReturnCorrectDescription() {
            DoubleDraugr f = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", f.Description);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            DoubleDraugr x = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }


        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
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
        public void ChangingKetchupNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
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
        public void ChangingMustardNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
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
        public void ChangingCheeseNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
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
        public void ChangingPicklesNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
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
        public void ChangingTomatoNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
            Assert.PropertyChanged(b, "Tomato", () =>
            {
                b.Tomato = false;
            });
            Assert.PropertyChanged(b, "Tomato", () =>
            {
                b.Tomato = true;
            });
        }


        [Fact]
        public void ChangingLettuceNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
            Assert.PropertyChanged(b, "Lettuce", () =>
            {
                b.Lettuce = false;
            });
            Assert.PropertyChanged(b, "Lettuce", () =>
            {
                b.Lettuce = true;
            });
        }


        [Fact]
        public void ChangingMayoNotifiesProperty()
        {
            DoubleDraugr b = new DoubleDraugr();
            Assert.PropertyChanged(b, "Mayo", () =>
            {
                b.Mayo = false;
            });
            Assert.PropertyChanged(b, "Mayo", () =>
            {
                b.Mayo = true;
            });
        }



        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(d);
        }

        [Fact]
        public void ShouldBeAnEntree() {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
        }


        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = false;
            Assert.False(d.Bun);
            d.Bun = true;
            Assert.True(d.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = false;
            Assert.False(d.Ketchup);
            d.Ketchup = true;
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = false;
            Assert.False(d.Mustard);
            d.Mustard = true;
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = false;
            Assert.False(d.Pickle);
            d.Pickle = true;
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = false;
            Assert.False(d.Cheese);
            d.Cheese = true;
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = false;
            Assert.False(d.Tomato);
            d.Tomato = true;
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = false;
            Assert.False(d.Lettuce);
            d.Lettuce = true;
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = false;
            Assert.False(d.Mayo);
            d.Mayo = true;
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("843", d.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese;
            d.Tomato = includeTomato;
            d.Lettuce = includeLettuce;
            d.Mayo = includeMayo;
            if (!includeBun) { Assert.Contains("Hold bun", d.SpecialInstructions); }
            if (!includeKetchup) { Assert.Contains("Hold ketchup", d.SpecialInstructions); }
            if (!includeMustard) { Assert.Contains("Hold mustard", d.SpecialInstructions); }
            if (!includePickle) { Assert.Contains("Hold pickle", d.SpecialInstructions); }
            if (!includeCheese) { Assert.Contains("Hold cheese", d.SpecialInstructions); }
            if (!includeTomato) { Assert.Contains("Hold tomato", d.SpecialInstructions); }
            if (!includeLettuce) { Assert.Contains("Hold lettuce", d.SpecialInstructions); }
            if (!includeMayo) { Assert.Contains("Hold mayo", d.SpecialInstructions); }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato
                && includeLettuce && includeMayo) { Assert.Empty(d.SpecialInstructions); }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString());
        }
    }
}