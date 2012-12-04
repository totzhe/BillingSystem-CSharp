using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Price
    {
        private long _tariffID;

        public long TariffID
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

        public Price(long tariffID, string prefix, float cost)
        {
            _tariffID = tariffID;
            _prefix = prefix;
            _cost = cost;
        }

    }
}
