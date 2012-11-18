using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Staff : Person
    {
        private string _position;

        public string Position
        {
            get { return _position; }
            set { /*_position = value;*/ }
        }

        public void SetPosition(string position)
        {
        }
    }
}
