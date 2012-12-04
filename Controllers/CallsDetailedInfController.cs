using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    class CallsDetailedInfController : DetailedInfController
    {
        public CallsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }
        
        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Call> calls = pn.SelectCalls(from, to);
            List<string[]> searchResult = new List<string[]>();

            foreach (Call c in calls)
            {
                string[] item = new string[6];
                item[0] = c.StartTime.ToShortDateString();
                item[1] = c.StartTime.ToShortTimeString();
                if (c.CalledNumber == pn.Number)
                {
                    item[2] = c.CallingNumber;
                    item[3] = Constants.Incoming;
                    item[5] = Constants.No;
                }
                else
                {
                    item[2] = c.CalledNumber;
                    Tariff tariff = pn.SelectTariffByDate(c.StartTime);
                    item[3] = Constants.Outgoing;
                    item[5] = BillingOperations.CalculateCallCost(c, tariff).ToString() + " " + Constants.Currency;
                }
                item[4] = c.Duration.ToString();
                searchResult.Add(item);
            }
            return searchResult;
        }
    }
}
