using BillingSystem.Controllers;
using BillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem.View
{
    public partial class FormTariff : Form
    {
        private ITariffController _controller;

        public FormTariff(ITariffController controller)
        {
            _controller = controller;
            InitializeComponent();
            foreach (Tariff item in _controller.listTariff)
            {
                dgvTariffName.Rows.Add(item.ID, item.Name);
            }
        }
    }
}
