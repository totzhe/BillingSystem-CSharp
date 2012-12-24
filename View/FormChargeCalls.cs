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
            this.Text = "Списание средств со счетов";
            _controller = controller;
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }
            cbMonth.SelectedIndex = DateTime.Now.Month - 1;
            for (int i = Constants.MinYear; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedItem = DateTime.Now.Year;
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dgvCharges.Rows.Clear();
            _controller.CalculateCharges(new DateTime((int)cbYear.SelectedItem, cbMonth.SelectedIndex + 1, 1, 0, 0, 0, 1));
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