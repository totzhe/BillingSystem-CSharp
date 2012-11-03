using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Tariff
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

        private string _description;

        public string Description
        {
            get { return _description; }
            set { /*_description = value;*/ }
        }

        private int _debtThreshold;

        public int DebtThreshold
        {
            get { return _debtThreshold; }
            set { /*_debtThreshold = value;*/ }
        }

        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { /*_active = value;*/ }
        }
    }
}
