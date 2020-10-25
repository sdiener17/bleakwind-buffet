/*
* Author: Sarah Diener
* Class name: SelectPayment.xaml.cs
* Purpose: Partial class used to create the select payment option screen and the different payment options
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
using RoundRegister;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for SelectPayment.xaml
    /// </summary>
    public partial class SelectPayment : UserControl {

        public List<Entree> entrees = new List<Entree>();
        public List<Drink> drinks = new List<Drink>();
        public List<Side> sides = new List<Side>();
        public double total;
        public RegisterControl register = new RegisterControl();


        public SelectPayment() {
            InitializeComponent();
            finalizeSaleButton.IsEnabled = false;
            //cashDrawerWindow.Visibility = Visibility.Hidden;
            //this.Visibility = Visibility.Visible;
        }


        /// <summary>
        /// Event handler for when the credit card option is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CreditButtonClick(object sender, RoutedEventArgs e) {
            RoundRegister.CardTransactionResult transaction = register.CardReader(total);
            if (transaction.Equals(CardTransactionResult.Approved)) {
                string messageText = "Card Approved";
                string caption = "Status";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result = MessageBox.Show(messageText, caption, button, icon);

                if (result.Equals(MessageBoxResult.OK)) {
                    finalizeSaleButton.IsEnabled = true;
                }
               
            }
            else if (transaction.Equals(CardTransactionResult.InsufficientFunds)) {
                string messageText = "Insufficient Funds";
                string caption = "Status";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result = MessageBox.Show(messageText, caption, button, icon);

                if (result.Equals(MessageBoxResult.OK)) {
                    finalizeSaleButton.IsEnabled = false;
                }
            }
            else {
                string messageText = "Please try again";
                string caption = "Status";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageText, caption, button, icon);

                if (result.Equals(MessageBoxResult.OK)) {
                    finalizeSaleButton.IsEnabled = false;
                }
            }
        }

        public EventHandler<CashDrawerEventArgs> OpenCashDrawer;
        /// <summary>
        /// Event handler for when the cash option is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CashButtonClick(object sender, RoutedEventArgs e) {
            //this.Visibility = Visibility.Hidden;
            //cashDrawerWindow.Visibility = Visibility.Visible;
            
            OpenCashDrawer?.Invoke(this, new CashDrawerEventArgs());
        }



        public EventHandler<CancelOrderEventArgs> FinalizeOrder;

        /// <summary>
        /// Event handler for when the finalize order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinalizeClick(object sender, RoutedEventArgs e) {
            FinalizeOrder?.Invoke(this, new CancelOrderEventArgs());
        }



        public EventHandler<ReturnToOrderEventArgs> ReturnOrder;

        /// <summary>
        /// Event handler for when the return to order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToOrderClick(object sender, RoutedEventArgs e) {
            //entrees.Clear();
            //drinks.Clear();
            //sides.Clear();
            ReturnOrder?.Invoke(this, new ReturnToOrderEventArgs());
        }


        /// <summary>
        /// Updates the order list box with the correct order items
        /// </summary>
        public void UpdateOrderListBox() {
            previewOrderListBox.Items.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (Entree entree in entrees) {
                sb.Append(entree.ToString() + " ");
                foreach (string si in entree.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                previewOrderListBox.Items.Add(sb.ToString());
                sb.Clear();
            }

            foreach (Side side in sides) {
                sb.Append(side.ToString() + " ");
                foreach (string si in side.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                previewOrderListBox.Items.Add(sb.ToString());
                sb.Clear();
            }
            foreach (Drink drink in drinks) {
                sb.Append(drink.ToString() + " ");
                foreach (string si in drink.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                previewOrderListBox.Items.Add(sb.ToString());
                sb.Clear();
            }
        }

    }
}
