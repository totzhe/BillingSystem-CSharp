using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers.IControllers;

namespace BillingSystem.View
{
    public partial class FormChargeCalls : Form
    {
        private IChargeCallsController _controller;

        public FormChargeCalls(IChargeCallsController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dgvCharges.Rows.Clear();
            _controller.CalculateCharges(dateTimePickerMonth.Value);
            foreach (Dictionary<string, string> d in _controller.GetCharges())
            {
                dgvCharges.Rows.Add(d["number"], d["sum"]);
            }
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            _controller.ConfirmCharges();
            DialogResult = DialogResult.OK;
        }
    }
}
