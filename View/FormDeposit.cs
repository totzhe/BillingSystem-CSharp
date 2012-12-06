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
    public partial class FormDeposit : Form
    {
        private BillingSystem.Controllers.IControllers.IDepositController _controller;
        public FormDeposit(long id)
        {
            _controller = new DepositController(id);
            InitializeComponent();
            Text = _controller.GetFullName();
            lblBalance.Text = _controller.GetBalance();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.Confirm(textBoxSum.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
