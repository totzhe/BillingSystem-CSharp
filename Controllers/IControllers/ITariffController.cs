using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.View;
using BillingSystem.Model;


namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера тарифов
    /// </summary>
    public interface ITariffController
    {
        List<Tariff> tariff { get; set; }
        long? selectTariffId { get; set; }

        void Save(string tbName, string tbDescription, DataGridView dgvPrice);
        List<string[]> Import(string FileName);
    }
}
