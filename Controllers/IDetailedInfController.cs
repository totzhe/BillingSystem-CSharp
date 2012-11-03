using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface IDetailedInfController
    {
        List<string> getPhoneNumbers();

        List<string[]> Search(DateTime from, DateTime to, string phoneNumber);
    }
}
