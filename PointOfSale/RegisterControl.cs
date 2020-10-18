/*
* Author: Sarah Diener
* Class name: RegisterControl.cs
* Purpose: Class used to control the different round register functions
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale {
    public class RegisterControl {

        public RegisterControl() {

        }


        public RoundRegister.CardTransactionResult CardReader(double amount) {
            RoundRegister.CardTransactionResult t = RoundRegister.CardReader.RunCard(amount);
            return t;
        }
    }
}
