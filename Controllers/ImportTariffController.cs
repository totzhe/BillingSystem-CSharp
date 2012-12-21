using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class ImportTariffController : ITariffController
    {
        public List<Tariff> tariff { get; set; }
        public long? selectTariffId { get; set; }

        public ImportTariffController()
        {
            tariff = Tariff.SelectActiveTariff();
        }

        public void Save(string tbName, string tbDescription, DataGridView dgvPrice)
        {
            if (tbName != String.Empty && tbDescription != String.Empty)
            {
                selectTariffId = Tariff.Add(tbName, tbDescription);
                Price.EditPrice(selectTariffId, dgvPrice);
            }
            else
            {
                MessageBox.Show("Имя и описание не может быть пустым");
            }
        }

        public List<string[]> Import(string fileName)
        {
            return FileExporter.CSVtoList(fileName);
        }
    }
}
