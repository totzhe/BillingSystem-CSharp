using System;
namespace BillingSystem.Controllers
{
    public interface IMonthlyInfoController
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> GetCharges(DateTime date);

        System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> GetPayments(DateTime date);

        string GetChargesSum();

        string GetPaymentsSum();
    }
}
