using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class PhoneNumber
    {
        private long _id;

        public long ID
        {
            get { return _id; }
        }

        private long _subscriberID;

        public long SubscriberID
        {
            get { return _subscriberID; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { /*_number = value;*/ }
        }

        private long _tariffID;

        public long TariffID
        {
            get { return _tariffID; }
            set { _tariffID = value; }
        }

        public PhoneNumber(long id, long subscriberID, string number, long tariffID)
        {
            _id = id;
            _subscriberID = subscriberID;
            _number = number;
            _tariffID = tariffID;
        }

        public void ChangeTariff(Tariff tariff)
        {
        }

        public void WriteOffMoney(Charge charge)
        {            
        }
    }
}
