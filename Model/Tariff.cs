using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Tariff
    {
        private long _id;

        public long ID
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

        private string _description;

        public string Description
        {
            get { return _description; }
            set { /*_description = value;*/ }
        }

        /*private double _debtThreshold;

        public double DebtThreshold
        {
            get { return _debtThreshold; }
        }*/

        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { /*_active = value;*/ }
        }

        public Tariff(long id, string name, string description, bool active)
        {
            _id = id;
            _name = name;
            _description = description;
            _active = active;
        }
    }
}
