using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class ChangeTariffController : ISelectTariffController
    {
        private PhoneNumber _number;

        private Tariff _tariff;
        
        public ChangeTariffController(PhoneNumber number)
        {
            _number = number;
            _tariff = _number.GetTariff();
        }

        public string GetCurrentTariffName()
        {
            if (_tariff != null)
                return _tariff.Name;
            else
                return Constants.No;
        }

        public string[] GetActiveTariffs()
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName("");
            string[] result = new string[tariffs.Count];
            int i = 0;
            foreach (Tariff t in tariffs)
                result[i++] = t.Name;
            return result;
        }

        public string GetPhoneNumber()
        {
            return _number.Number;
        }

        public string GetTariffDescription(string tariffName)
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName(tariffName);
            if (tariffs.Count > 0)
                return tariffs[0].Description;
            else
                return null;
        }

        public void Confirm(string tariffName)
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName(tariffName);
            if (tariffs.Count > 0)
            {
                _number.TariffID = tariffs[0].ID;
                //DatabaseUtils.Update(_number);
            }
        }

        public void Cancel()
        {
        }
    }
}
