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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for OrderDisplay.xaml
    /// </summary>
    public partial class OrderDisplay : UserControl {

        double subtotal;
        double tax;
        double total;

        int numberOfCombosApplied;
        int numberOfEntreesAccountedFor=0;
        int numberOfDrinksAccountedFor=0;
        int numberOfSidesAccountedFor=0;

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


        public void AddEntreeToOrder(Entree e) {
            orderListBox.Items.Add(e.ToString());
            subtotal += e.Price;
            FindCombos();
            UpdateSubtotalLabel();
            
        }

        public void AddDrinkToOrder(Drink d) {
            orderListBox.Items.Add(d.ToString());
            subtotal += d.Price;
            FindCombos();
            UpdateSubtotalLabel();
            
        }

        public void AddSideToOrder(Side s) {
            orderListBox.Items.Add(s.ToString());
            subtotal += s.Price;
            FindCombos();
            UpdateSubtotalLabel();
            
        }

        /// <summary>
        /// Finds the combos in the current order and recalculates the price based on the number of combos.
        /// </summary>
        public void FindCombos() {
            int numberEntrees = 0;
            int numberSides = 0; ;
            int numberDrinks = 0;
            int numberOfCombos = 0;

            //Finds number of entrees, sides, and drinks
            foreach(string item in orderListBox.Items) {
                if ((item.Contains("Briar")) || (item.Contains("Double")) || (item.Contains("Thalmor")) || (item.Contains("Philly")) ||
                    (item.Contains("Smoke")) || (item.Contains("Garden")) || (item.Contains("Thugs"))){
                    numberEntrees++;
                }
                else if ((item.Contains("Sailor")) || (item.Contains("Aretino")) || (item.Contains("Milk")) || (item.Contains("Water")) ||
                    (item.Contains("Candle"))) {
                    numberDrinks++;
                }
                else {
                    numberSides++;
                }
            }

            System.Diagnostics.Debug.WriteLine("Number entrees before: "+numberEntrees);
            System.Diagnostics.Debug.WriteLine("Number drinks before: " + numberDrinks);
            System.Diagnostics.Debug.WriteLine("Number sides before: " + numberSides);
            System.Diagnostics.Debug.WriteLine("");

            //Finds number of combos
            for (int i = numberEntrees; i >0; i--) {
                if((numberSides>0) && (numberDrinks > 0)) {
                    numberOfCombos++;
                    numberDrinks--;
                    numberSides--;
                   
                }
                else { break; }
            }

            System.Diagnostics.Debug.WriteLine("Number entrees after: " + numberEntrees);
            System.Diagnostics.Debug.WriteLine("Number drinks after: " + numberDrinks);
            System.Diagnostics.Debug.WriteLine("Number sides after: " + numberSides);
            System.Diagnostics.Debug.WriteLine("Number combos before: " + numberOfCombos);
            System.Diagnostics.Debug.WriteLine("Number applied before: " + numberOfCombosApplied);
            System.Diagnostics.Debug.WriteLine("");

            //Taking into account combos that have already been applied
            if (numberOfCombos > numberOfCombosApplied) {
                subtotal -= numberOfCombos - numberOfCombosApplied;
                numberOfCombosApplied = numberOfCombos;
            }

            System.Diagnostics.Debug.WriteLine("Number combos after: " + numberOfCombos);
            System.Diagnostics.Debug.WriteLine("Number applied after: " + numberOfCombosApplied);
            System.Diagnostics.Debug.WriteLine("--------------------------");
            System.Diagnostics.Debug.WriteLine("");


        }//end FindCombos



        /// <summary>
        /// Updates the totatl displayed in on the screen
        /// </summary>
        public void UpdateSubtotalLabel() {
            subtotalLabel.Content = "Subtotal: $" + subtotal;
        }

    }
}
