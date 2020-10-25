/*
* Author: Sarah Diener
* Class name: CashDrawerModelView.cs
* Purpose: Class used as a cash register to keep track of what the customer has payed and what change is owed.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PointOfSale {
    public class CashDrawerModelView :INotifyPropertyChanged{

        public event PropertyChangedEventHandler PropertyChanged;


        private int inDrawerHundredB = 0;
        public int InDrawerHundred {
            get {
                return inDrawerHundredB;
            }
            set {
                inDrawerHundredB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerHundred"));
            }
        }

        private int inDrawerFiftyB = 0;
        public int InDrawerFiftyB {
            get { return inDrawerFiftyB; }
            set {
                inDrawerFiftyB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerFiftyB"));
            }
        }

        private int inDrawerTwentyB = 0;
        public int InDrawerTwentyB {
            get { return inDrawerTwentyB; }
            set {
                inDrawerTwentyB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerTwentyB"));
            }
        }



        private int inDrawerTenB = 0;
        public int InDrawerTenB {
            get { return inDrawerTenB; }
            set {
                inDrawerTenB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerTenB"));
            }
        }



        private int inDrawerFiveB = 0;
        public int InDrawerFiveB {
            get { return inDrawerFiveB; }
            set {
                inDrawerFiveB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerFiveB"));
            }
        }




        private int inDrawerTwoB = 0;
        public int InDrawerTwoB {
            get { return inDrawerTwoB; }
            set {
                inDrawerTwoB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerTwoB"));
            }
        }


        private int inDrawerOneB = 0;
        public int InDrawerOneB {
            get { return inDrawerOneB; }
            set {
                inDrawerOneB = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerOneB"));
            }
        }



        private int inDrawerOneC = 0;
        public int InDrawerOneC {
            get { return InDrawerOneC; }
            set {
                inDrawerOneC = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerOneC"));
            }
        }




        private int inDrawerFiftyC = 0;
        public int InDrawerFiftyC {
            get { return inDrawerFiftyC; }
            set {
                inDrawerFiftyC = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerFiftyC"));
            }
        }


        private int inDrawerQuarter = 0;
        public int InDrawerQuarter {
            get { return inDrawerQuarter; }
            set {
                inDrawerQuarter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerQuarter"));
            }
        }

        private int inDrawerDime = 0;
        public int InDrawerDime {
            get { return inDrawerDime; }
            set {
                inDrawerDime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerDime"));
            }
        }

        private int inDrawerNickle = 0;
        public int InDrawerNickle {
            get { return inDrawerNickle; }
            set {
                inDrawerNickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerNickle"));
            }
        }

        private int inDrawerPenny = 0;
        public int InDrawerPenny {
            get { return inDrawerPenny; }
            set {
                inDrawerPenny = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InDrawerPenny"));
            }
        }


        private int fromCustomerHundredB = 0;
        public int FromCustomerHundredB {
            get { return fromCustomerHundredB; }
            set {
                fromCustomerHundredB = value;
            }
        }


    }
}
