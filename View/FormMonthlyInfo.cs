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
    /// <summary>
    /// Класс формы информации за месяц. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormMonthlyInfo : Form
    {
        private IMonthlyInfoController _controller;

        /// <summary>
        /// Инициализирует класс FormMonthlyInfo.
        /// </summary>
        /// <param name="controller"></param>
        public FormMonthlyInfo(IMonthlyInfoController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void Search()
        {
            dgvCharges.Rows.Clear();
            dgvPayments.Rows.Clear();
            foreach (Dictionary<string, string> d in _controller.GetCharges(dateTimePickerMonth.Value))
            {
                dgvCharges.Rows.Add(d["number"], d["sum"]);
            }
            lblChargesSum.Text = _controller.GetChargesSum();
            foreach (Dictionary<string, string> d in _controller.GetPayments(dateTimePickerMonth.Value))
            {
                dgvPayments.Rows.Add(d["subscriber"], d["sum"]);
            }
            lblPaymentsSum.Text = _controller.GetPaymentsSum();
        }

        private void dateTimePickerMonth_CloseUp(object sender, EventArgs e)
        {
            Search();
        }
    }
}
