using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public interface ITariffController
    {
        List<Tariff> listTariff { get; set; }
    }
}
