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

        public FormSelectTariff(long phoneNumberID)
        {
            _controller = new SelectTariffController(phoneNumberID);
            InitializeComponent();

            comboBoxTariff.Items.AddRange(_controller.GetActiveTariffs());
            comboBoxTariff.SelectedIndex = 0;
        }

        private void comboBoxTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = _controller.GetTariffDescription(comboBoxTariff.SelectedItem.ToString());
        }
    }
}
