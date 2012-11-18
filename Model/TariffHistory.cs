using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class TariffHistory
    {
        private long _id;

        public long ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private long _phoneID;

        public long PhoneID
        {
            get { return _phoneID; }
            set { /*_phoneID = value;*/ }
        }

        private long _tariffID;

        public long TariffID
        {
            get { return _tariffID; }
            set { /*_tariffID = value;*/ }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate.ToLocalTime(); }
            set { /*_startDate = value;*/ }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate.ToLocalTime(); }
            set { /*_endDate = value;*/ }
        }
    }
}
