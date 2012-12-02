using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers;
using BillingSystem.Model;

namespace BillingSystem.View
{
    public partial class FormDetailedInf : Form
    {       
        private IDetailedInfController _controller;

        public FormDetailedInf(long id)
        {
            _controller = new DetailedInfController(id);
            InitializeComponent();
            lbFullName.Text = _controller.GetSubscriberFullName();
            List<string> _phoneNumbers = _controller.GetPhoneNumbers(id);
            lbNumbers.Enabled = true;
            lbNumbers.Items.Clear();
            foreach (string n in _phoneNumbers)
                lbNumbers.Items.Add(n);
            lbNumbers.SelectedIndex = 0;
            rbCalls.Checked = true;
            rbTariffs.Checked = false;
            rbServices.Checked = false;
            rbPayments.Checked = false;
        }

        private void Search()
        {
            dgvInf.Rows.Clear();
            List<string[]> items = _controller.Search(lbNumbers.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value);
            foreach (string[] item in items)
            {
                dgvInf.Rows.Add(item);
            }
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_CloseUp(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {
            Search();
        }
        // TODO: Сдеать, чтобы при нажатии кнопки "Поиск" контроллер переключался на соответствующий выбронному радиобаттону и затем вызывал метод Search

        // TODO: На этой же форме заодно будут выводиться фамилия, имя, отчество, почта и баланс абонента (без редактирования)

    }
}
