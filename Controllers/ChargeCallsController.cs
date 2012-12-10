using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class ChargeCallsController : BillingSystem.Controllers.IControllers.IChargeCallsController
    {
        private List<Charge> _charges = new List<Charge>();

        private DateTime to = DateTime.Now;
        private DateTime from = DateTime.Now;
        private bool calculated = false;

        public void CalculateCharges(DateTime date)
        {
            from = new DateTime(date.Year, date.Month, 1, 0, 0, 0, 0);
            to = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month), 23, 59, 59, 59);
            _charges = BillingOperations.CalculateCharges(from, to);
            calculated = true;
        }

        public List<Dictionary<string, string>> GetCharges()
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach (Charge charge in _charges)
            {
                Dictionary<string, string> d = new Dictionary<string, string>();
                d.Add("number", PhoneNumber.SelectPhoneNumberByID(charge.PhoneID).Number);
                d.Add("sum", Math.Round(charge.Sum, 2).ToString() + " " + Constants.Currency);
                result.Add(d);
            }
            return result;
        }

        public void ConfirmCharges()
        {
            if (calculated)
            {
                long serviceID = Service.SelectServiceByName(Constants.ChargeCalls).ID;
                Charge.RemoveCharges(serviceID, from, to);
                foreach (Charge charge in _charges)
                {
                    charge.WriteOff();
                }
            }
        }
    }
}
