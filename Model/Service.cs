using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Service
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { /*_name = value;*/ }
        }

        private double _cost;

        public double Cost
        {
            get { return _cost; }
            set { /*_cost = value;*/ }
        }
    }
}
