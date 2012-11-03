using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Price
    {
        private int _tariffID;

        public int TariffID
        {
            get { return _tariffID; }
            set { /*_tariffID = value;*/ }
        }

        private string _prefix;

        public string Prefix
        {
            get { return _prefix; }
            set { /*_prefix = value;*/ }
        }

        private double _cost;

        public double Cost
        {
            get { return _cost; }
            set { /*_cost = value;*/ }
        }
    }
}
