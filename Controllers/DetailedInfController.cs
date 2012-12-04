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
            List<PhoneNumber> phones = _subscriber.GetPhoneNumbers();
            List<string> searchResult = new List<string>();
            foreach (PhoneNumber n in phones)
                searchResult.Add(n.Number);
            return searchResult;
        }

        public abstract List<string[]> Search(string phoneNumber, DateTime from, DateTime to);

        public DetailedInfController(long subscriberID)
        {
            _subscriber = Subscriber.SelectSubscriberByID(subscriberID);
            if (_subscriber == null)
                throw new BillingSystem.Exceptions.ModelObjectNotFoundException("Subscriber with number = " + subscriberID);
        }
    }
}
