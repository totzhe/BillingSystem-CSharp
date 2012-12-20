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
    /// <summary>
    /// Класс формы пополнения счета абонента. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormDeposit : Form
    {
        private BillingSystem.Controllers.IControllers.IDepositController _controller;
        
        /// <summary>
        /// Инициализирует новый экземпляр класса FormDeposit, получая в качестве параметра объект класса, реализующего интерфейс IDepositController.
        /// </summary>
        /// <param name="controller">Контроллер пополнения счета</param>
        public FormDeposit(IDepositController controller)
        {
            _controller = controller;
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
