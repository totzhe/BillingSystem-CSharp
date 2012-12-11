using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public abstract class DetailedInfController : IDetailedInfController
    {
        protected Subscriber _subscriber;

        public DetailedInfController(long subscriberID)
        {
            _subscriber = Subscriber.SelectSubscriberByID(subscriberID);
            if (_subscriber == null)
                throw new BillingSystem.Exceptions.ModelObjectNotFoundException("Subscriber with number = " + subscriberID);
        }

        public virtual string GetSubscriberFullName()
        {
            if (_subscriber != null)
            {
                return _subscriber.GetFullName();
            }
            else
                return null;
        }

        public virtual List<string> GetPhoneNumbers()
        {
            List<PhoneNumber> searchResult = _subscriber.GetPhoneNumbers();
            List<string> result = new List<string>();
            foreach (PhoneNumber n in searchResult)
                result.Add(n.Number);
            return result;
        }

        public string GetBalanceByDate(DateTime date)
        {
            return Math.Round(_subscriber.GetBalanceByDate(date), 2).ToString() + " " + Constants.Currency;
        }

        public string GetBalance()
        {
            return Math.Round(_subscriber.Balance, 2).ToString() + " " + Constants.Currency;
        }

        public abstract List<string[]> Search(string phoneNumber, DateTime from, DateTime to);

    }
}
