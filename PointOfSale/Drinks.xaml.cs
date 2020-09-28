/*
* Author: Sarah Diener
* Class name: Drinks.xaml.cs
* Purpose: Partial class used to create the drinks section of the POS and interaction logic.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl {

        public Drinks() {
            InitializeComponent();
            RefreshButtons();
        }


        void SodaClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("soda");
            ClickedDrink("soda");
        }


        void AppleJuiceClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("appleJuice");
            ClickedDrink("appleJuice");
        }


        void MilkClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("milk");
            ClickedDrink("milk");
        }


        void CoffeeClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("coffee");
            ClickedDrink("coffee");
        }


        void WaterClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("water");
            ClickedDrink("water");
        }


        void DoneButtonClick(object sender, RoutedEventArgs e) {
            RefreshButtons();
        }


        void CancelButtonClick(object sender, RoutedEventArgs e) {
            RefreshButtons();
        }



        /// <summary>
        /// Hides all other drink items when button <paramref name="b"/> is clicked. Also moves the clicked button to
        /// the top.
        /// </summary>
        /// <param name="b">The button that was clicked</param>
        void HideAndMoveButtons(string d) {
            if (d.Equals("soda")) {
                appleJuice.Visibility = Visibility.Hidden;
                milk.Visibility = Visibility.Hidden;
                coffee.Visibility = Visibility.Hidden;
                water.Visibility = Visibility.Hidden;
            }
            else if (d.Equals("appleJuice")) {
                soda.Visibility = Visibility.Hidden;
                milk.Visibility = Visibility.Hidden;
                coffee.Visibility = Visibility.Hidden;
                water.Visibility = Visibility.Hidden;
                Grid.SetRow(appleJuice, 0);
            }
            else if (d.Equals("milk")) {
                appleJuice.Visibility = Visibility.Hidden;
                soda.Visibility = Visibility.Hidden;
                coffee.Visibility = Visibility.Hidden;
                water.Visibility = Visibility.Hidden;
                Grid.SetRow(milk, 0);
            }
            else if (d.Equals("coffee")) {
                appleJuice.Visibility = Visibility.Hidden;
                milk.Visibility = Visibility.Hidden;
                soda.Visibility = Visibility.Hidden;
                water.Visibility = Visibility.Hidden;
                Grid.SetRow(coffee, 0);
            }
            else if (d.Equals("water")) {
                appleJuice.Visibility = Visibility.Hidden;
                milk.Visibility = Visibility.Hidden;
                coffee.Visibility = Visibility.Hidden;
                soda.Visibility = Visibility.Hidden;
                Grid.SetRow(water, 0);
            }
            else { return; }
        }



            /// <summary>
            /// Sets all entrees back to visible and puts them in the correct row
            /// </summary>
            void RefreshButtons() {
            soda.Visibility = Visibility.Visible;
            appleJuice.Visibility = Visibility.Visible;
            milk.Visibility = Visibility.Visible;
            coffee.Visibility = Visibility.Visible;
            water.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            Grid.SetRow(soda, 0);
            Grid.SetRow(appleJuice, 1);
            Grid.SetRow(milk, 2);
            Grid.SetRow(coffee, 3);
            Grid.SetRow(water, 4);
            sodaOptions.Visibility = Visibility.Hidden;
            appleJuiceOptions.Visibility = Visibility.Hidden;
            milkOptions.Visibility = Visibility.Hidden;
            coffeeOptions.Visibility = Visibility.Hidden;
            waterOptions.Visibility = Visibility.Hidden;
        }



        /// <summary>
        /// Shows the done and cancel button, along with the option to choose special instructions for the selected
        /// entree.
        /// </summary>
        /// <param name="b"></param>
        void ClickedDrink(string b) {
            doneButton.Visibility = Visibility.Visible;
            cancelButton.Visibility = Visibility.Visible;

            if (b.Equals("soda")) {
                sodaOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("appleJuice")) {
                appleJuiceOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("milk")) {
                milkOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("coffee")) {
                coffeeOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("water")) {
                waterOptions.Visibility = Visibility.Visible;
            }
            else { return; }
        }

    }
}
