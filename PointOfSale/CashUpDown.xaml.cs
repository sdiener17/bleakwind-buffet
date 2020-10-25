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
    /// Interaction logic for CashUpDown.xaml
    /// </summary>
    public partial class CashUpDown : UserControl {

        int curNumber = 0;
        
        public CashUpDown() {
            InitializeComponent();
        }

        public void PlusButtonClick(object sender, RoutedEventArgs e) {
            curNumber++;
            textBlock.Text = curNumber.ToString();
        }

        public void MinusButtonClick(object sender, RoutedEventArgs e) {
            if(curNumber > 0) {
                curNumber--;
                textBlock.Text = curNumber.ToString();
            }
        }
    }
}
