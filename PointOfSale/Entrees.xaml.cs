/*
* Author: Sarah Diener
* Class name: Entrees.xaml.cs
* Purpose: Partial class used to create the entrees section of the POS and interaction logic.
*/
using BleakwindBuffet.Data.Entrees;
using System;
using System.CodeDom;
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
    /// Interaction logic for Entrees.xaml
    /// </summary>
    public partial class Entrees : UserControl {

        Entree currentOrderItem;
        BriarheartBurger bhb = new BriarheartBurger();
        DoubleDraugr dd = new DoubleDraugr();
        ThalmorTriple tt = new ThalmorTriple();
        SmokehouseSkeleton ss = new SmokehouseSkeleton();
        PhillyPoacher pp = new PhillyPoacher();
        GardenOrcOmelette goo = new GardenOrcOmelette();
        ThugsTBone ttb = new ThugsTBone();

        public Entrees() {
            InitializeComponent();
            RefreshButtons();

        }


        /// <summary>
        /// Event handler for briarheart burger button. Calls methods to show only the briarheartburger button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("briarBurger");
            ClickedEntree("briarBurger");
            currentOrderItem = bhb;
            //BriarheartBurger  b = new BriarheartBurger();

        }

        /// <summary>
        /// Event handler for double draugr button. Calls methods to show only the double draugr button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("doubleBurger");
            ClickedEntree("doubleBurger");
            currentOrderItem = dd;
        }


        /// <summary>
        /// Event handler for thalmor triple button. Calls methods to show only the thalmor triple button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("tripleBurger");
            ClickedEntree("tripleBurger");
            currentOrderItem = tt;
        }


        /// <summary>
        /// Event handler for philly poacher button. Calls methods to show only the philly poacher button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("philly");
            ClickedEntree("philly");
            currentOrderItem = pp;
        }


        /// <summary>
        /// Event handler for smokehouse skeleton button. Calls methods to show only the smokehouse skeleton button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SkeletonClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("skeleton");
            ClickedEntree("skeleton");
            currentOrderItem = ss;
        }


        /// <summary>
        /// Event handler for garden orc omelette button. Calls methods to show only the garden orc omelette button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOmeletteClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("omelette");
            ClickedEntree("omelette");
            currentOrderItem = goo;
        }



        /// <summary>
        /// Event handler for thugs t-bone button. Calls methods to show only the thugs t-bone button and display the
        /// specialization options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TBoneClick(object sender, RoutedEventArgs e) {
            HideAndMoveButtons("tbone");
            ClickedEntree("tbone");
            currentOrderItem = ttb;
        }


        public EventHandler<AddEToOrderEventArgs> AddToOrder;

        /// <summary>
        /// Event handler for done button. Adds item with specifications to the order and resets buttons to the proper location
        /// and visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButtonClick(object sender, RoutedEventArgs e) {
            AddToOrder?.Invoke(this, new AddEToOrderEventArgs(currentOrderItem));
            RefreshButtons();
        }


        /// <summary>
        /// Event handler for cancel button. Calls method to reset buttons back to the proper location and visibility. Makes no
        /// changes to the order or total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButtonClick(object sender, RoutedEventArgs e) {
            RefreshButtons();
        }


        /// <summary>
        /// Hides all other entree items when button <paramref name="b"/> is clicked. Also moves the clicked button to
        /// the top.
        /// </summary>
        /// <param name="b">The button that was clicked</param>
        void HideAndMoveButtons(string b) {
            if (b.Equals("briarBurger")) {
                doubleBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;

            }
            else if (b.Equals("doubleBurger")) {
                briarBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;
                Grid.SetRow(doubleBurger,0);
            }
            else if (b.Equals("tripleBurger")) {
                doubleBurger.Visibility = Visibility.Hidden;
                briarBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;
                Grid.SetRow(tripleBurger, 0);
            }
            else if (b.Equals("philly")) {
                briarBurger.Visibility = Visibility.Hidden;
                doubleBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;
                Grid.SetRow(philly, 0);
            }
            else if (b.Equals("skeleton")) {
                doubleBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                briarBurger.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;
                Grid.SetRow(skeleton, 0);
            }
            else if (b.Equals("omelette")) {
                doubleBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                briarBurger.Visibility = Visibility.Hidden;
                tbone.Visibility = Visibility.Hidden;
                Grid.SetRow(omelette, 0);
            }
            else if (b.Equals("tbone")) {
                doubleBurger.Visibility = Visibility.Hidden;
                tripleBurger.Visibility = Visibility.Hidden;
                philly.Visibility = Visibility.Hidden;
                skeleton.Visibility = Visibility.Hidden;
                omelette.Visibility = Visibility.Hidden;
                briarBurger.Visibility = Visibility.Hidden;
                Grid.SetRow(tbone, 0);
            }
            else { return; }
        }




        /// <summary>
        /// Sets all entrees back to visible and puts them in the correct row
        /// </summary>
        void RefreshButtons() {
            briarBurger.Visibility = Visibility.Visible;
            doubleBurger.Visibility = Visibility.Visible;
            tripleBurger.Visibility = Visibility.Visible;
            philly.Visibility = Visibility.Visible;
            skeleton.Visibility = Visibility.Visible;
            omelette.Visibility = Visibility.Visible;
            tbone.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            Grid.SetRow(briarBurger, 0);
            Grid.SetRow(doubleBurger, 1);
            Grid.SetRow(tripleBurger, 2);
            Grid.SetRow(philly, 3);
            Grid.SetRow(skeleton, 4);
            Grid.SetRow(omelette, 5);
            Grid.SetRow(tbone, 6);
            briarheartOptions.Visibility = Visibility.Hidden;
            draugrOptions.Visibility = Visibility.Hidden;
            thalmorOptions.Visibility = Visibility.Hidden;
            phillyOptions.Visibility = Visibility.Hidden;
            omeletteOptions.Visibility = Visibility.Hidden;
            skeletonOptions.Visibility = Visibility.Hidden;
            tboneOptions.Visibility = Visibility.Hidden;

            bhb = new BriarheartBurger();
            dd = new DoubleDraugr();
            tt = new ThalmorTriple();
            ss = new SmokehouseSkeleton();
            pp = new PhillyPoacher();
            goo = new GardenOrcOmelette();
            ttb = new ThugsTBone();
            briarheartOptions.DataContext = bhb;
            draugrOptions.DataContext = dd;
            thalmorOptions.DataContext = tt;
            skeletonOptions.DataContext = ss;
            phillyOptions.DataContext = pp;
            omeletteOptions.DataContext = goo;
            tboneOptions.DataContext = ttb;
        }




        /// <summary>
        /// Shows the done and cancel button, along with the option to choose special instructions for the selected
        /// entree.
        /// </summary>
        /// <param name="b"></param>
        void ClickedEntree(string b) {
            doneButton.Visibility = Visibility.Visible;
            cancelButton.Visibility = Visibility.Visible;

            if (b.Equals("briarBurger")) {
                
                briarheartOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("doubleBurger")) {
                draugrOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("tripleBurger")) {
                thalmorOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("philly")) {
                phillyOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("skeleton")) {
                skeletonOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("omelette")) {
                omeletteOptions.Visibility = Visibility.Visible;
            }
            else if (b.Equals("tbone")) {
                tboneOptions.Visibility = Visibility.Visible;
            }
            else { return; }
        }
    }
}
