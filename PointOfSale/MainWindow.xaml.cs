/*
* Author: Sarah Diener
* Class name: MainWindow.xaml.cs
* Purpose: Partial class used to control the different panels showed throughout the order process
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {


        


        public MainWindow() {
            InitializeComponent();
            
            createOrderWindow.Visibility = Visibility.Hidden;
            selectPaymentWindow.Visibility = Visibility.Hidden;
            cashDrawerWindow.Visibility = Visibility.Hidden;

            homeScreenWindow.NewOrder += OnNewOrderClick;
            createOrderWindow.orderDisplayWindow.FinishOrder += OnFinishOrderClick;
            createOrderWindow.orderDisplayWindow.CancelOrder += OnCancelOrderClick;
            selectPaymentWindow.ReturnOrder += OnReturnOrderClick;
            selectPaymentWindow.OpenCashDrawer += OnCashOptionClick;
            cashDrawerWindow.BackButton += OnBackButtonClick;
            cashDrawerWindow.FinishCashButton += OnFinishCashButtonClick;
            //CreateOrder.DataContext = new Order();
           //createOrderWindow. += OnAddToOrderClick;
        }


        private int orderNumber = 0;

        /// <summary>
        /// Event handler for when the create new order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnNewOrderClick(object sender, OrderClickEventArgs e) {
            createOrderWindow.Visibility = Visibility.Visible;
            homeScreenWindow.Visibility = Visibility.Hidden;
            if (orderNumber < 999) {
                orderNumber++;
            }
            else {
                orderNumber = 1;
            }
            createOrderWindow.orderDisplayWindow.OrderNumber = orderNumber;
            createOrderWindow.orderDisplayWindow.entrees.Clear();
            createOrderWindow.orderDisplayWindow.sides.Clear();
            createOrderWindow.orderDisplayWindow.drinks.Clear();
            createOrderWindow.orderDisplayWindow.UpdateOrderListBox();
            createOrderWindow.orderDisplayWindow.UpdateSubtotalLabel();
            createOrderWindow.orderDisplayWindow.UpdateTaxLabel();
            createOrderWindow.orderDisplayWindow.UpdateTotalLabel();
        }



        /// <summary>
        /// Event handler for when the finish order button is clicked on the order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFinishOrderClick(object sender, FinishOrderEventArgs e) {
            createOrderWindow.Visibility = Visibility.Hidden;

            selectPaymentWindow.Visibility = Visibility.Visible;
            selectPaymentWindow.entrees = e.entrees;
            selectPaymentWindow.drinks = e.drinks;
            selectPaymentWindow.sides = e.sides;
            selectPaymentWindow.total = e.total;
            selectPaymentWindow.UpdateOrderListBox();
        }


        /// <summary>
        /// Event handler for when the cancel order button is clicked on the order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderClick(object sender, CancelOrderEventArgs e) {
            createOrderWindow.Visibility = Visibility.Hidden;
            selectPaymentWindow.Visibility = Visibility.Hidden;
            homeScreenWindow.Visibility = Visibility.Visible;
        }


        /// <summary>
        /// Event handler for when the return to order button is clicked on the select payment options screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnReturnOrderClick(object sender, ReturnToOrderEventArgs e) {
            createOrderWindow.Visibility = Visibility.Visible;
            selectPaymentWindow.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Event handler for when the cash option is clicked on the selelct payment options screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCashOptionClick(object sender, CashDrawerEventArgs e) {
            cashDrawerWindow.totalCashDrawer = selectPaymentWindow.total;
            cashDrawerWindow.totalSaleText.Text = "Total Sale: $ " + string.Format("{0:0.00}", selectPaymentWindow.total);
            selectPaymentWindow.Visibility = Visibility.Hidden;
            cashDrawerWindow.Visibility = Visibility.Visible;
        }

        
        /// <summary>
        /// Event handler for when the back button is clicked on the cash drawer window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBackButtonClick(object sender, BackButtonEventArgs e) {
            selectPaymentWindow.Visibility = Visibility.Visible;
            cashDrawerWindow.Visibility = Visibility.Hidden;
        }


        /// <summary>
        /// Event handler for when the finish button is clicked for the cash payment option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFinishCashButtonClick(object sender, FinishCashPaymentEventArgs e) {
            selectPaymentWindow.Visibility = Visibility.Visible;
            selectPaymentWindow.finalizeSaleButton.IsEnabled = true;
            cashDrawerWindow.Visibility = Visibility.Hidden;
        }

    }
}
