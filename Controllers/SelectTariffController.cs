using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class SelectTariffController : ISelectTariffController
    {
        private PhoneNumber number;

        private Tariff tariff;
        
        public SelectTariffController(long phoneNumberID)
        {
            number = DatabaseUtils.SelectPhoneNumberByID(phoneNumberID);
            tariff = DatabaseUtils.SelectTariffByID(number.TariffID);
        }

        public string GetCurrentTariff()
        {
            return tariff.Name;
        }

        public string[] GetActiveTariffs()
        {
            List<Tariff> tariffs = DatabaseUtils.SelectActiveTariffs("");
            string[] result = new string[tariffs.Count];
            int i = 0;
            foreach (Tariff t in tariffs)
                result[i++] = t.Name;
            return result;
        }

        public string GetPhoneNumber()
        {
            return number.Number;
        }

        public string GetTariffDescription(string tariffName)
        {
            List<Tariff> tariffs = DatabaseUtils.SelectActiveTariffs(tariffName);
            if (tariffs.Count > 0)
                return tariffs[0].Description;
            else
                return null;
        }

        public void Confirm(string tariffName)
        {
            List<Tariff> tariffs = DatabaseUtils.SelectActiveTariffs(tariffName);
            if (tariffs.Count > 0)
            {
                number.TariffID = tariffs[0].ID;
                DatabaseUtils.UpdatePhoneNumber(number);
            }
        }

        public void Cancel()
        {
        }
    }
}
