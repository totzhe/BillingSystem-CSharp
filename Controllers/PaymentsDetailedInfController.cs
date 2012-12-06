using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    class PaymentsDetailedInfController : DetailedInfController
    {
        public PaymentsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Payment> payments = _subscriber.SelectPayments(from, to);
            List<string[]> searchResult = new List<string[]>();
            foreach (Payment p in payments)
            {
                string[] item = new string[3];
                item[0] = p.Date.ToShortDateString();
                item[1] = p.Date.ToLongTimeString();
                item[2] = Math.Round(p.Sum, 2).ToString() + " " + Constants.Currency;
                searchResult.Add(item);
            }
            return searchResult;
        }
    }
}
