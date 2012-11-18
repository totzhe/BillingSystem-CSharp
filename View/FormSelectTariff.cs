using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers;

namespace BillingSystem.View
{
    public partial class FormSelectTariff : Form
    {
        private ISelectTariffController _controller;

        public FormSelectTariff(ISelectTariffController controller)
        {
            _controller = controller;
            InitializeComponent();

            comboBoxTariff.Items.AddRange(_controller.GetActiveTariffs());
            comboBoxTariff.SelectedIndex = 0;
            labelCurrentNariffName.Text = "Текущий тариф: " + _controller.GetCurrentTariffName();
        }

        private void comboBoxTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = _controller.GetTariffDescription(comboBoxTariff.SelectedItem.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.Confirm(comboBoxTariff.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
            DialogResult = DialogResult.Cancel;
        }
    }
}
