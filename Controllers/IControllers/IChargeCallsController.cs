using System;
namespace BillingSystem.Controllers.IControllers
{
    public interface IChargeCallsController
    {
        void CalculateCharges(DateTime date);
        void ConfirmCharges();
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> GetCharges();
    }
}
