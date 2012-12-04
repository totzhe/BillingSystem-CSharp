using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    class TariffsDetailedInfController : DetailedInfController
    {
        public TariffsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<TariffHistory> tariffHistory = pn.SelectTariffHistory(from, to);
            List<string[]> searchResult = new List<string[]>();

            foreach (TariffHistory th in tariffHistory)
            {
                string[] items = new string[4];
                items[0] = th.StartDate.ToShortDateString();
                items[1] = th.StartDate.ToShortTimeString();
                items[2] = th.TariffName;
                if (th.EndDate != null)
                {
                    items[3] = th.EndDate.Value.ToShortDateString();
                }
                else
                {
                    items[3] = Constants.NoInfo;
                }
                searchResult.Add(items);
            }
            return searchResult;
        }
    }
}
