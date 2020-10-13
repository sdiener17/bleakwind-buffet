/*
* Author: Sarah Diener
* Class name: Drinks.xaml.cs
* Purpose: Partial class used to create the drinks section of the POS and interaction logic.
*/
/*
* Author: Sarah Diener
* Class name: Drinks.xaml.cs
* Purpose: Partial class used to control the Drinks user control
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
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl {

        Drink currentOrderItem;
        SailorSoda ss = new SailorSoda();
        AretinoAppleJuice aaj = new AretinoAppleJuice();
        MarkarthMilk mm = new MarkarthMilk();
        WarriorWater ww = new WarriorWater();
        CandlehearthCoffee chc = new CandlehearthCoffee();

        public Drinks() {
            InitializeComponent();
            RefreshButtons();
        }


        /// <summary>
        /// Event handler for when the sailor soda button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SodaClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("soda");
            ClickedDrink("soda");
            currentOrderItem = ss;
        }

        /// <summary>
        /// Event handler for when the apple juice button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AppleJuiceClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("appleJuice");
            ClickedDrink("appleJuice");
            currentOrderItem = aaj;
        }



        /// <summary>
        /// Event handler for when the milk button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MilkClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("milk");
            ClickedDrink("milk");
            currentOrderItem = mm;
        }



        /// <summary>
        /// Event handler for when the coffee button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CoffeeClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("coffee");
            ClickedDrink("coffee");
            currentOrderItem = chc;
        }



        /// <summary>
        /// Event handler for when the water button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WaterClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("water");
            ClickedDrink("water");
            currentOrderItem = ww;
        }


        public EventHandler<AddDToOrderEventArgs> AddToOrder;



        /// <summary>
        /// Event handler for when the done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButtonClick(object sender, RoutedEventArgs e) {
            AddToOrder?.Invoke(this, new AddDToOrderEventArgs(currentOrderItem));
            RefreshButtons();
        }



        /// <summary>
        /// Event handler for when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                sodaOptionsPanel.Visibility = Visibility.Hidden;
                appleJuiceOptionsPanel.Visibility = Visibility.Hidden;
                milkOptionsPanel.Visibility = Visibility.Hidden;
                coffeeOptionsPanel.Visibility = Visibility.Hidden;
                waterOptionsPanel.Visibility = Visibility.Hidden;

            ss = new SailorSoda();
            aaj = new AretinoAppleJuice();
            mm = new MarkarthMilk();
            chc = new CandlehearthCoffee();
            ww = new WarriorWater();
            sodaOptionsS.DataContext = ss;
            sodaOptionsIY.DataContext = ss;
            sodaOptionsIN.DataContext = ss;
            sodaOptionsF.DataContext = ss;
            appleJuiceOptionsS.DataContext = aaj;
            appleJuiceOptionsI.DataContext = aaj;
            milkOptionsS.DataContext = mm;
            milkOptionsI.DataContext = mm;
            coffeeOptionsS.DataContext = chc;
            coffeeOptionsI.DataContext = chc;
            coffeeOptionsC.DataContext = chc;
            coffeeOptionsD.DataContext = chc;
            waterOptionsS.DataContext = ww;
            waterOptionsI.DataContext = ww;
            waterOptionsL.DataContext = ww;

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
                sodaOptionsPanel.Visibility = Visibility.Visible;
            }
            else if (b.Equals("appleJuice")) {
                appleJuiceOptionsPanel.Visibility = Visibility.Visible;
            }
            else if (b.Equals("milk")) {
                milkOptionsPanel.Visibility = Visibility.Visible;
            }
            else if (b.Equals("coffee")) {
                coffeeOptionsPanel.Visibility = Visibility.Visible;
            }
            else if (b.Equals("water")) {
                waterOptionsPanel.Visibility = Visibility.Visible;
            }
            else { return; }
        }

    }
}
