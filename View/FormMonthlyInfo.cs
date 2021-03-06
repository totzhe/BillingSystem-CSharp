﻿using System;
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
            this.Text = "Просмотр статистики за месяц";
            _controller = controller;
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }
            cbMonth.SelectedIndex = DateTime.Now.Month-1;
            for (int i = Constants.MinYear; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedItem = DateTime.Now.Year;
        }

        private void Search()
        {
            if (cbYear.SelectedItem != null && cbMonth.SelectedIndex >= 0)
            {
                dgvCharges.Rows.Clear();
                dgvPayments.Rows.Clear();

                foreach (Dictionary<string, string> d in _controller.GetCharges(new DateTime((int)cbYear.SelectedItem, cbMonth.SelectedIndex + 1, 1, 0, 0, 0, 1)))
                {
                    dgvCharges.Rows.Add(d["number"], d["sum"]);
                }
                lblTotalCompounded.Text = _controller.GetChargesSum();
                foreach (Dictionary<string, string> dict in _controller.GetPayments(new DateTime((int)cbYear.SelectedItem, cbMonth.SelectedIndex + 1, 1, 0, 0, 0, 1)))
                {
                    dgvPayments.Rows.Add(dict["subscriber"], dict["sum"]);
                }
                lblTotalLiquidate.Text = _controller.GetPaymentsSum();
                lblTotalCost.Text = _controller.GetDebt();
            }
        }

        private void SelectedMonthChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
