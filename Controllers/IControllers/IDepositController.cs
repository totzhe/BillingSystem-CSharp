using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers.IControllers
{
    public interface IDepositController
    {
        string GetFullName();

        string GetBalance();

        void Confirm(string sum);

        void Cancel();
    }
}
