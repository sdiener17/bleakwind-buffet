/*
* Author: Sarah Diener
* Class name: CreateOrder.xaml.cs
* Purpose: Partial class used to create the main screen of a POS.
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : UserControl {
        public CreateOrder() {
            InitializeComponent();
            
            entreesWindow.AddToOrder += OnDoneEntreeClick;
            drinksWindow.AddToOrder += OnDoneDrinkClick;
            sidesWindow.AddToOrder += OnDoneSideClick;
        }



        /// <summary>
        /// Event handler for when the done button is clicked on an entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDoneEntreeClick(object sender, AddEToOrderEventArgs e) {
            orderDisplayWindow.AddEntreeToOrder(e.orderItem);
        }


        /// <summary>
        /// Event handler for when the done button is clicked on a drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDoneDrinkClick(object sender, AddDToOrderEventArgs e) {
            orderDisplayWindow.AddDrinkToOrder(e.orderItem);
        }



        /// <summary>
        /// Event handler for when the done button is clicked on a side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDoneSideClick(object sender, AddSToOrderEventArgs e) {
            orderDisplayWindow.AddSideToOrder(e.orderItem);
        }

    }
}
