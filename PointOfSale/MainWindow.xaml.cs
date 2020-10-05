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
            homeScreenWindow.NewOrder += OnNewOrderClick;
            createOrderWindow.orderDisplayWindow.FinishOrder += OnFinishOrderClick;
        }

        void OnNewOrderClick(object sender, OrderClickEventArgs e) {
            createOrderWindow.Visibility = Visibility.Visible;
            homeScreenWindow.Visibility = Visibility.Hidden;
        }

        void OnFinishOrderClick(object sender, FinishOrderEventArgs e) {
            createOrderWindow.Visibility = Visibility.Hidden;
            homeScreenWindow.Visibility = Visibility.Visible;
        }

    }
}
