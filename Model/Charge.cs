using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Charge
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

        private long _serviceID;

        public long OperationID
        {
            get { return _serviceID; }
            set { /*_serviceID = value;*/ }
        }

        private double _sum;

        public double Sum
        {
            get { return _sum; }
            set { /*_sum = value;*/ }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date.ToLocalTime(); }
            set { /*_date = value;*/ }
        }


        public Charge(PhoneNumber phone, Service service, double sum)
        {
            _date = System.DateTime.UtcNow;
            _phoneID = phone.ID;
            _serviceID = service.ID;
            _sum = sum + service.Cost;
        }
    }
}
