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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen: UserControl {
        public HomeScreen() {
            InitializeComponent();
        }

        public event EventHandler<OrderClickEventArgs> NewOrder;


        

        public void StartOrderClick(object sender, EventArgs e) {
            
            NewOrder?.Invoke(this, new OrderClickEventArgs());
        }
    }
}
