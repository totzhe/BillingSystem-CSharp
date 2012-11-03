using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Other;

namespace BillingSystem.Model
{
    public class Subscriber : Person
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set { /*_email = value;*/ }
        }

        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { /*_balance = value;*/ }
        }

        /*public void WriteOffMoney(double sum)
        {
        }*/

        public void DepositMoney(double sum)
        {
        }

        public void ChangeEmail(string email)
        {
        }
    }
}
