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
                return _subscriber.Surname + " " + _subscriber.Name + " " + _subscriber.Patronymic;
            }
            else
                return null;
        }

        public virtual List<string> GetPhoneNumbers(long id)
        {
            List<PhoneNumber> searchResult = _subscriber.GetPhoneNumbers();
            List<string> result = new List<string>();
            foreach (PhoneNumber n in searchResult)
                result.Add(n.Number);
            return result;
        }

        public abstract List<string[]> Search(string phoneNumber, DateTime from, DateTime to);

    }
}
