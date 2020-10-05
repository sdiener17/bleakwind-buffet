/*
* Author: Sarah Diener
* Class name: OrderDisplay.xaml.cs
* Purpose: Partial class used to display the order and order totals.
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
    /// Interaction logic for OrderDisplay.xaml
    /// </summary>
    public partial class OrderDisplay : UserControl {
        public OrderDisplay() {
            InitializeComponent();
        }


        public event EventHandler<FinishOrderEventArgs> FinishOrder;

        public void FinishClick(object sender, EventArgs e) {
            FinishOrder.Invoke(this, new FinishOrderEventArgs());
        }

        public void CancelClick(object sender, EventArgs e) {
            string messageText = "Are you sure you want to cancel the current order?";
            string caption = "Cancel Order";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageText, caption, button, icon);

            switch (result) {
                case MessageBoxResult.Yes:
                    FinishOrder.Invoke(this, new FinishOrderEventArgs());
                    break;
                case MessageBoxResult.No:
                    
                    break;
            }
        }
    }
}
