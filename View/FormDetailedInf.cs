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
        private long _subscriberID;

        public FormDetailedInf(long subscriberId)
        {
            InitializeComponent();

            lbNumbers.Enabled = true;
            lbNumbers.Items.Clear();
                        
            rbtnCalls.Checked = true;
            rbtnTariffs.Checked = false;
            rbtnPayments.Checked = false;
            rbtnServices.Checked = false;

            _subscriberID = subscriberId;
            initController(_subscriberID);
            lblFullName.Text = _controller.GetSubscriberFullName();
            List<string> _phoneNumbers = _controller.GetPhoneNumbers();
            foreach (string n in _phoneNumbers)
            {
                lbNumbers.Items.Add(n);
            }
            lbNumbers.SelectedIndex = 0;
        }

        private void initController(long subscriberId)
        {
            if (rbtnCalls.Checked == true)
            {
                _controller = new CallsDetailedInfController(subscriberId);
            }
            if (rbtnTariffs.Checked == true)
            {
                _controller = new TariffsDetailedInfController(subscriberId);
            }
        }

        private void CallsSearch()
        {
            List<string[]> items = _controller.Search(lbNumbers.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value);
            foreach (string[] item in items)
            {
                dgvInf.Rows.Add(item);
            }
        }

        private void TariffHistorySearch()
        {
            List<string[]> items = _controller.Search(lbNumbers.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value);
            foreach (string[] item in items)
            {
                dgvInf.Rows.Add(item);
            }
        }

        private void initDataGridView()
        {
            if (rbtnCalls.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 6;
                dgvInf.Columns[0].Name = "Дата";
                dgvInf.Columns[1].Name = "Время";
                dgvInf.Columns[2].Name = "Номер";
                dgvInf.Columns[3].Name = "Тип";
                dgvInf.Columns[4].Name = "Длительность";
                dgvInf.Columns[5].Name = "Стоимость";
                CallsSearch();
            }
            if (rbtnTariffs.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 4;
                dgvInf.Columns[0].Name = "Дата подключения";
                dgvInf.Columns[1].Name = "Время подключения";
                dgvInf.Columns[2].Name = "Тарифный план";
                dgvInf.Columns[3].Name = "Дата отключения";
                TariffHistorySearch();
            }
            if (rbtnPayments.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 3;
                dgvInf.Columns[0].Name = "Дата";
                dgvInf.Columns[1].Name = "Время";
                dgvInf.Columns[2].Name = "Сумма";
            }
            if (rbtnServices.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 4;
                dgvInf.Columns[0].Name = "Дата";
                dgvInf.Columns[1].Name = "Время";
                dgvInf.Columns[2].Name = "Операция";
                dgvInf.Columns[3].Name = "Стоимость";
            }
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            initController(_subscriberID);
            initDataGridView();            
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_CloseUp(object sender, EventArgs e)
        {
            initController(_subscriberID);
            initDataGridView();
        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {
            initController(_subscriberID);
            initDataGridView();
        }

        private void rbtnCalls_Click(object sender, EventArgs e)
        {
            if (rbtnCalls.Checked == false)
            {
                rbtnCalls.Checked = true;
                rbtnTariffs.Checked = false;
                rbtnPayments.Checked = false;
                rbtnServices.Checked = false;
            }
            initController(_subscriberID);
            initDataGridView();
        }

        private void rbtnTariffs_Click(object sender, EventArgs e)
        {
            if (rbtnTariffs.Checked == false)
            {
                rbtnTariffs.Checked = true;
                rbtnCalls.Checked = false;
                rbtnPayments.Checked = false;
                rbtnServices.Checked = false;
            }
            initController(_subscriberID);
            initDataGridView();
        }

        private void rbtnPayments_Click(object sender, EventArgs e)
        {
            if (rbtnPayments.Checked == false)
            {
                rbtnPayments.Checked = true;
                rbtnCalls.Checked = false;
                rbtnTariffs.Checked = false;
                rbtnServices.Checked = false;
            }
            
            initDataGridView();
        }

        private void rbtnServices_Click(object sender, EventArgs e)
        {
            if (rbtnServices.Checked == false)
            {
                rbtnServices.Checked = true;
                rbtnCalls.Checked = false;
                rbtnTariffs.Checked = false;
                rbtnPayments.Checked = false;
            }
            initDataGridView();
        }

        // TODO: Сдеать, чтобы при нажатии кнопки "Поиск" контроллер переключался на соответствующий выбронному радиобаттону и затем вызывал метод CallsSearch

        // TODO: На этой же форме заодно будут выводиться фамилия, имя, отчество, почта и баланс абонента (без редактирования)

    }
}
