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

        public List<Entree> entrees = new List<Entree>();
        public List<Side> sides = new List<Side>();
        public List<Drink> drinks = new List<Drink>();

        

        public OrderDisplay() {
            InitializeComponent();
            
            
        }

        private int orderNumber;
        public int OrderNumber {
            get {
                return orderNumber;
            }
            set {
                orderNumber = value;
                orderNumberLabel.Content = "Order #" + OrderNumber;
            }
        }

        public event EventHandler<FinishOrderEventArgs> FinishOrder;


        /// <summary>
        /// Event handler for when the finish order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinishClick(object sender, EventArgs e) {
            FinishOrder.Invoke(this, new FinishOrderEventArgs(entrees,sides,drinks,total));
        }


        public event EventHandler<CancelOrderEventArgs> CancelOrder;

        /// <summary>
        /// Event handler for when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelClick(object sender, EventArgs e) {
            string messageText = "Are you sure you want to cancel the current order?";
            string caption = "Cancel Order";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageText, caption, button, icon);

            switch (result) {
                case MessageBoxResult.Yes:
                    CancelOrder.Invoke(this, new CancelOrderEventArgs());
                    break;
                case MessageBoxResult.No:
                    
                    break;
            }
        }


        /// <summary>
        /// Event handler for when the remove button is clicked. Removes the selected item from the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveClick(object sender, RoutedEventArgs e) {
            if(orderListBox.Items.Count != 0) {
                foreach(Entree entree in entrees) {
                    if ((orderListBox.SelectedItem.ToString().Equals(entree.ToString()))) {
                        entrees.Remove(entree);
                        break;
                    }
                }
                foreach (Side side in sides) {
                    if ((orderListBox.SelectedItem.ToString().Equals(side.ToString()))) {
                        sides.Remove(side);
                        break;
                    }
                }
                foreach (Drink drink in drinks) {
                    if ((orderListBox.SelectedItem.ToString().Equals(drink.ToString()))) {
                        drinks.Remove(drink);
                        break;
                    }
                }
                UpdateOrderListBox();
                FindRemoveCombos();
                UpdateSubtotalLabel();
                UpdateTaxLabel();
                UpdateTotalLabel();
            }
            
        }



        public void PreviewClick(object sender, RoutedEventArgs e) {
            StringBuilder sb = new StringBuilder();
            foreach(Entree entree in entrees) {
                sb.Append(entree.ToString() + " ");
                foreach(string si in entree.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                sb.Append("\n");
            }
            
            foreach (Side side in sides) {
                sb.Append(side.ToString() + " ");
                foreach (string si in side.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                sb.Append("\n");
            }
            foreach (Drink drink in drinks) {
                sb.Append(drink.ToString() + " ");
                foreach (string si in drink.SpecialInstructions) {
                    sb.Append(si + " ");
                }
                sb.Append("\n");
            }


            string messageText = sb.ToString();
            string caption = "Order Preview";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result = MessageBox.Show(messageText, caption, button);

            switch (result) {
                case MessageBoxResult.OK:
                    
                    break;
                
            }
        }


        /// <summary>
        /// Adds the entree 'e' to the order
        /// </summary>
        /// <param name="e"></param>
        public void AddEntreeToOrder(Entree e) {
            //orderListBox.Items.Add(e.ToString());
            entrees.Add(e);
            UpdateOrderListBox();
            //subtotal += e.Price;
            FindCombos();
            UpdateSubtotalLabel();
            UpdateTaxLabel();
            UpdateTotalLabel();
            
        }


        /// <summary>
        /// Adds the drink 'd' to the order
        /// </summary>
        /// <param name="d"></param>
        public void AddDrinkToOrder(Drink d) {
            //orderListBox.Items.Add(d.ToString());
            drinks.Add(d);
            UpdateOrderListBox();
            //subtotal += d.Price;
            FindCombos();
            UpdateSubtotalLabel();
            UpdateTaxLabel();
            UpdateTotalLabel();
            
        }


        /// <summary>
        /// Adds the side 's' to the order
        /// </summary>
        /// <param name="s"></param>
        public void AddSideToOrder(Side s) {
            //orderListBox.Items.Add(s.ToString());
            sides.Add(s);
            UpdateOrderListBox();
            //subtotal += s.Price;
            FindCombos();
            UpdateSubtotalLabel();
            UpdateTaxLabel();
            UpdateTotalLabel();
            
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

            //System.Diagnostics.Debug.WriteLine("Number entrees before: "+numberEntrees);
            //System.Diagnostics.Debug.WriteLine("Number drinks before: " + numberDrinks);
            //System.Diagnostics.Debug.WriteLine("Number sides before: " + numberSides);
            //System.Diagnostics.Debug.WriteLine("");

            //Finds number of combos
            for (int i = numberEntrees; i >0; i--) {
                if((numberSides>0) && (numberDrinks > 0)) {
                    numberOfCombos++;
                    numberDrinks--;
                    numberSides--;
                   
                }
                else { break; }
            }

            //System.Diagnostics.Debug.WriteLine("Number entrees after: " + numberEntrees);
            //System.Diagnostics.Debug.WriteLine("Number drinks after: " + numberDrinks);
            //System.Diagnostics.Debug.WriteLine("Number sides after: " + numberSides);
            //System.Diagnostics.Debug.WriteLine("Number combos before: " + numberOfCombos);
            //System.Diagnostics.Debug.WriteLine("Number applied before: " + numberOfCombosApplied);
            //System.Diagnostics.Debug.WriteLine("");

            //Taking into account combos that have already been applied
            if (numberOfCombos > numberOfCombosApplied) {
                subtotal -= numberOfCombos - numberOfCombosApplied;
                numberOfCombosApplied = numberOfCombos;
            }

            combosLabel.Content = "Combos Applied: " + numberOfCombosApplied;

            //System.Diagnostics.Debug.WriteLine("Number combos after: " + numberOfCombos);
            //System.Diagnostics.Debug.WriteLine("Number applied after: " + numberOfCombosApplied);
            //System.Diagnostics.Debug.WriteLine("--------------------------");
            //System.Diagnostics.Debug.WriteLine("");


        }//end FindCombos



        /// <summary>
        /// Updates the totatl displayed in on the screen
        /// </summary>
        public void UpdateSubtotalLabel() {
            subtotal = 0;
            foreach (Entree entree in entrees) {
                subtotal += entree.Price;
            }

            foreach (Side side in sides) {
                subtotal += side.Price;
            }
            foreach (Drink drink in drinks) {
                subtotal += drink.Price;
            }
            subtotalLabel.Content = "Subtotal: $" + string.Format("{0:0.00}", subtotal);
        }


        /// <summary>
        /// Computes the tax on the current order and updates the label
        /// </summary>
        public void UpdateTaxLabel() {
            tax = subtotal * .08;
            taxLabel.Content = "Tax: $" + string.Format("{0:0.00}", tax);
        }


        /// <summary>
        /// Updates the total cost label
        /// </summary>
        public void UpdateTotalLabel() {
            total = subtotal + tax;
            totalLabel.Content = "Total: $" + string.Format("{0:0.00}", total);
        }


        /// <summary>
        /// Updates the order list box
        /// </summary>
        public void UpdateOrderListBox() {
            orderListBox.Items.Clear();
            foreach (Entree entree in entrees) {
                orderListBox.Items.Add(entree.ToString());
            }

            foreach (Side side in sides) {
                orderListBox.Items.Add(side.ToString());
            }
            foreach (Drink drink in drinks) {
                orderListBox.Items.Add(drink.ToString());
            }
        }


        /// <summary>
        /// Finds the combos in the current order and recalculates the price based on the number of combos. Specifically made
        /// for when an item is removed from the order.
        /// </summary>
        public void FindRemoveCombos() {
            int numberEntrees = 0;
            int numberSides = 0; ;
            int numberDrinks = 0;
            int numberOfCombos = 0;

            //Finds number of entrees, sides, and drinks
            foreach (string item in orderListBox.Items) {
                if ((item.Contains("Briar")) || (item.Contains("Double")) || (item.Contains("Thalmor")) || (item.Contains("Philly")) ||
                    (item.Contains("Smoke")) || (item.Contains("Garden")) || (item.Contains("Thugs"))) {
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


            //Finds number of combos
            for (int i = numberEntrees; i > 0; i--) {
                if ((numberSides > 0) && (numberDrinks > 0)) {
                    numberOfCombos++;
                    numberDrinks--;
                    numberSides--;

                }
                else { break; }
            }


            //Taking into account combos that have already been applied
            if (numberOfCombos != numberOfCombosApplied) {
                subtotal ++;
                numberOfCombosApplied --;
            }

            combosLabel.Content = "Combos Applied: " + numberOfCombosApplied;

        }//end FindCombos


    }
}
