/*
* Author: Sarah Diener
* Class name: Drinks.xaml.cs
* Purpose: Partial class used to create the sides section of the POS and interaction logic.
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for Sides.xaml
    /// </summary>
    public partial class Sides : UserControl {

        Side currentOrderItem;
        DragonbornWaffleFries dwf = new DragonbornWaffleFries();
        VokunSalad vs = new VokunSalad();
        FriedMiraak fm = new FriedMiraak();
        MadOtarGrits mog = new MadOtarGrits();

        public Sides() {
            InitializeComponent();
            RefreshButtons();
            

        }

        void FriesClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("fries");
            ClickedDrink("fries");
            currentOrderItem = dwf;
            friesOptions.DataContext = dwf;
        }


        void SaladClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("salad");
            ClickedDrink("salad");
            currentOrderItem = vs;
        }


        void GritsClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("grits");
            ClickedDrink("grits");
            currentOrderItem = mog;
        }


        void MiraakClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("miraak");
            ClickedDrink("miraak");
            currentOrderItem = fm;
        }


        public EventHandler<AddSToOrderEventArgs> AddToOrder;


        void DoneButtonClick(object sender, RoutedEventArgs e) {
            AddToOrder?.Invoke(this, new AddSToOrderEventArgs(currentOrderItem));
            RefreshButtons();
        }


        void CancelButtonClick(object sender, RoutedEventArgs e) {
            RefreshButtons();
            
        }



        /// <summary>
        /// Hides all other side items when button <paramref name="b"/> is clicked. Also moves the clicked button to
        /// the top.
        /// </summary>
        /// <param name="b">The button that was clicked</param>
        void HideAndMoveButtons(string d) {
            if (d.Equals("fries")) {
                salad.Visibility = Visibility.Hidden;
                grits.Visibility = Visibility.Hidden;
                miraak.Visibility = Visibility.Hidden;
            }
            else if (d.Equals("salad")) {
                fries.Visibility = Visibility.Hidden;
                grits.Visibility = Visibility.Hidden;
                miraak.Visibility = Visibility.Hidden;
                Grid.SetRow(salad, 0);
            }
            else if (d.Equals("grits")) {
                salad.Visibility = Visibility.Hidden;
                fries.Visibility = Visibility.Hidden;
                miraak.Visibility = Visibility.Hidden;
                Grid.SetRow(grits, 0);
            }
            else if (d.Equals("miraak")) {
                salad.Visibility = Visibility.Hidden;
                grits.Visibility = Visibility.Hidden;
                fries.Visibility = Visibility.Hidden;
                Grid.SetRow(miraak, 0);
            }
            else { return; }
        }



        /// <summary>
        /// Sets all entrees back to visible and puts them in the correct row
        /// </summary>
        void RefreshButtons() {
            fries.Visibility = Visibility.Visible;
            salad.Visibility = Visibility.Visible;
            grits.Visibility = Visibility.Visible;
            miraak.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            Grid.SetRow(fries, 0);
            Grid.SetRow(salad, 1);
            Grid.SetRow(grits, 2);
            Grid.SetRow(miraak, 3);
            friesOptions.Visibility = Visibility.Hidden;
            saladOptions.Visibility = Visibility.Hidden;
            gritsOptions.Visibility = Visibility.Hidden;
            miraakOptions.Visibility = Visibility.Hidden;

            dwf = new DragonbornWaffleFries();
            vs = new VokunSalad();
            fm = new FriedMiraak();
            mog = new MadOtarGrits();
            friesOptions.DataContext = dwf;
            saladOptions.DataContext = vs;
            miraakOptions.DataContext = fm;
            gritsOptions.DataContext = mog;
        }



        /// <summary>
        /// Shows the done and cancel button, along with the option to choose special instructions for the selected
        /// entree.
        /// </summary>
        /// <param name="b"></param>
        void ClickedDrink(string b) {
            doneButton.Visibility = Visibility.Visible;
            cancelButton.Visibility = Visibility.Visible;

            if (b.Equals("fries")) {
                
                friesOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("salad")) {
                saladOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("grits")) {
                gritsOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("miraak")) {
                miraakOptions.Visibility = Visibility.Visible;
            }
            else { return; }
        }


    }
}
