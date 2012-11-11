﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Payment
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

        public Payment(Subscriber subscriber, double sum)
        {
            _date = System.DateTime.UtcNow;
            _subscriberID = subscriber.ID;
            _sum = sum;
        }
    }
}