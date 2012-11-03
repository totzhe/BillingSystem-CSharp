using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class PhoneNumber
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private int _subscriberID;

        public int SubscriberID
        {
            get { return _subscriberID; }
            set { }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { /*_number = value;*/ }
        }

        private int _tariffID;

        public int TariffID
        {
            get { return _tariffID; }
            set { /*_tariffID = value;*/ }
        }


        public void ChangeTariff(Tariff tariff)
        {
        }

        public void WriteOffMoney(Charge charge)
        {            
        }
    }
}
