﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.View;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Конроллер для изменения тарифов
    /// </summary>
    public class EditTariffController : ITariffController
    {
        public List<Tariff> tariff { get; set; }
        public long? selectTariffId { get; set; }

        public EditTariffController()
        {
            tariff = Tariff.SelectActiveTariff();
        }

        public void Save(string tbName, string tbDescription, DataGridView dgvPrice)
        {
            if (tbName != String.Empty && tbDescription != String.Empty)
            {
                Tariff.EditTariffData(selectTariffId, tbName, tbDescription);
                Price.EditPrice(selectTariffId, dgvPrice);
                tariff.Clear();
                tariff = Tariff.SelectActiveTariff();
            }
            else
            {
                MessageBox.Show("Имя и описание не может быть пустым");
            }
        }

        public List<string[]> Import(string FileName)
        {
            throw new NotImplementedException();
        }
    }
}
