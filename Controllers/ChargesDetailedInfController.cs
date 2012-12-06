using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    class ChargesDetailedInfController : DetailedInfController
    {
        public ChargesDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber phone = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Charge> charges = phone.SelectCharges(phone, from, to);
            List<string[]> result = new List<string[]>();

            foreach (Charge c in charges)
            {
                string [] item = new string[4];
                item[0] = c.Date.ToShortDateString();
                item[1] = c.Date.ToLongTimeString();
                item[2] = c.GetService().Name;
                item[3] = c.Sum.ToString();
                result.Add(item);
            }
            return result;
        }
    }
}
