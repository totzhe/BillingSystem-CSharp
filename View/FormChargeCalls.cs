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
    /// Класс формы списания средств со счетов всех абонентов. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormChargeCalls : Form
    {
        private IChargeCallsController _controller;

        /// <summary>
        /// Инициализирует новый экземпляр класса FormChargeCalls, получая в качестве параметра объект класса, реализующего интерфейс IChargeCallsController.
        /// </summary>
        /// <param name="controller">Контроллер списания средств за звонки</param>
        public FormChargeCalls(IChargeCallsController controller)
        {
            this.Text = "Списание средств со счета";
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
