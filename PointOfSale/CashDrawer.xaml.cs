/*
* Author: Sarah Diener
* Class name: CashDrawer.xaml.cs
* Purpose: Partial class used to create interaction logic for the CashDrawer.xaml, which shows the cash register and provides 
* functionality for paying for the order with cash.
*/
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for CashDrawer.xaml
    /// </summary>
    public partial class CashDrawer : UserControl {

        CashDrawerModelView cashDrawer = new CashDrawerModelView();
        public double totalCashDrawer;

        public CashDrawer() {
            InitializeComponent();
            this.DataContext = cashDrawer;
        }

        public EventHandler<BackButtonEventArgs> BackButton;
        /// <summary>
        /// Event handler for when the back button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BackButtonClick(object sender, RoutedEventArgs e) {
            BackButton?.Invoke(this, new BackButtonEventArgs());
        }


        public EventHandler<FinishCashPaymentEventArgs> FinishCashButton;
        /// <summary>
        /// Event handler for when the finish payment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinishButtonClick(object sender, RoutedEventArgs  e) {
            FinishCashButton?.Invoke(this, new FinishCashPaymentEventArgs());
        }
    }
}
