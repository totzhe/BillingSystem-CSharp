using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface ISelectTariffController
    {
        string GetCurrentTariffName();

        string[] GetActiveTariffs();

        string GetPhoneNumber();

        string GetTariffDescription(string tariffName);

        void Confirm(string tariffName);

        void Cancel();
    }
}
