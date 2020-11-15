/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {

        [Fact]
        public void ShouldReturnCorrectDescription() {
            GardenOrcOmelette f = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", f.Description);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
        }

        [Fact]
        public void ChangingTomatoNotifiesProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = false;
            });
            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = true;
            });
        }


        [Fact]
        public void ChangingBroccoliNotifiesProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = false;
            });
            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = true;
            });
        }


        [Fact]
        public void ChangingCheddarNotifiesProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = false;
            });
            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = true;
            });
        }


        [Fact]
        public void ChangingMushroomNotifiesProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();
            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = false;
            });
            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = true;
            });
        }



        [Fact]
        public void ShouldBeAssignableToIOrderItem() {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(go);
        }

        [Fact]
        public void ShouldBeAnEntree() {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }


        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = false;
            Assert.False(go.Broccoli);
            go.Broccoli = true;
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = false;
            Assert.False(go.Tomato);
            go.Tomato = true;
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = false;
            Assert.False(go.Cheddar);
            go.Cheddar = true;
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("404", go.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Tomato = includeTomato;
            go.Cheddar = includeCheddar;
            if (!includeBroccoli) { Assert.Contains("Hold broccoli", go.SpecialInstructions); }
            if (!includeMushrooms) { Assert.Contains("Hold mushrooms", go.SpecialInstructions); }
            if (!includeTomato) { Assert.Contains("Hold tomato", go.SpecialInstructions); }
            if (!includeCheddar) { Assert.Contains("Hold cheddar", go.SpecialInstructions); }
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) { Assert.Empty(go.SpecialInstructions); }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }
    }
}