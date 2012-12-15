using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class EditTariffController : ITariffController
    {
        public List<Tariff> listTariff { get; set; }

        public EditTariffController()
        {
            listTariff = new List<Tariff>();
            listTariff = Tariff.SelectAllTariff();
        }
    }
}
