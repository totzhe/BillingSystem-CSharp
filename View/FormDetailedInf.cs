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
using Kent.Boogaart.KBCsv;
using Kent.Boogaart.HelperTrinity;

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
            Text = _controller.GetSubscriberFullName();
            List<string> _phoneNumbers = _controller.GetPhoneNumbers();
            foreach (string n in _phoneNumbers)
            {
                lbNumbers.Items.Add(n);
            }
            lbNumbers.SelectedIndex = 0;
            initBalance();
        }

        private void initBalance()
        {
            lblBalance.Text = _controller.GetBalance();
            lblFromBalance.Text = _controller.GetBalanceByDate(dtpFrom.Value);
            lblToBalance.Text = _controller.GetBalanceByDate(dtpTo.Value);
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
            if (rbtnPayments.Checked == true)
            {
                _controller = new PaymentsDetailedInfController(subscriberId);
            }
            if (rbtnServices.Checked == true)
            {
                _controller = new ChargesDetailedInfController(subscriberId);
            }
        }

        private void Search()
        {
            List<string[]> items = _controller.Search(lbNumbers.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value);
            dgvInf.Rows.Clear();
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
                //Search();
            }
            if (rbtnTariffs.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 5;
                dgvInf.Columns[0].Name = "Дата подключения";
                dgvInf.Columns[1].Name = "Время подключения";
                dgvInf.Columns[2].Name = "Тарифный план";
                dgvInf.Columns[3].Name = "Дата отключения";
                dgvInf.Columns[4].Name = "Время отключения";
                //Search();
            }
            if (rbtnPayments.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 3;
                dgvInf.Columns[0].Name = "Дата";
                dgvInf.Columns[1].Name = "Время";
                dgvInf.Columns[2].Name = "Сумма";
                //Search();
            }
            if (rbtnServices.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 4;
                dgvInf.Columns[0].Name = "Дата";
                dgvInf.Columns[1].Name = "Время";
                dgvInf.Columns[2].Name = "Услуга";
                dgvInf.Columns[3].Name = "Стоимость";
                //dgvInf.Columns[4].Name = "Состояние баланса";
                //Search();
            }
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initController(_subscriberID);
            //initDataGridView();     
            Search();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                FileExporter.DGVtoCSV(dgvInf, saveFileDialog.FileName);
            }
        }

        private void dtpFrom_CloseUp(object sender, EventArgs e)
        {
            //initController(_subscriberID);
            //initDataGridView();  
            dtpFrom.Value = dtpFrom.Value.Date;
            //System.Windows.Forms.MessageBox.Show(dtpFrom.Value.ToString());
            initBalance();
            Search();
        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {
            //initController(_subscriberID);
            //initDataGridView();   
            dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(59);
            //System.Windows.Forms.MessageBox.Show(dtpTo.Value.ToString());
            initBalance();
            Search();
        }

        private void rbtnCalls_Click(object sender, EventArgs e)
        {
            if (rbtnCalls.Checked == false)
            {
                lbNumbers.Enabled = true;
                rbtnCalls.Checked = true;
                rbtnTariffs.Checked = false;
                rbtnPayments.Checked = false;
                rbtnServices.Checked = false;
                initController(_subscriberID);
                initDataGridView();
                Search();
            }
        }

        private void rbtnTariffs_Click(object sender, EventArgs e)
        {
            if (rbtnTariffs.Checked == false)
            {
                lbNumbers.Enabled = true;
                rbtnTariffs.Checked = true;
                rbtnCalls.Checked = false;
                rbtnPayments.Checked = false;
                rbtnServices.Checked = false;
                initController(_subscriberID);
                initDataGridView();
                Search();
            }
        }

        private void rbtnPayments_Click(object sender, EventArgs e)
        {
            if (rbtnPayments.Checked == false)
            {
                lbNumbers.Enabled = false;
                rbtnPayments.Checked = true;
                rbtnCalls.Checked = false;
                rbtnTariffs.Checked = false;
                rbtnServices.Checked = false;
                initController(_subscriberID);
                initDataGridView();
                Search();
            }
        }

        private void rbtnServices_Click(object sender, EventArgs e)
        {
            if (rbtnServices.Checked == false)
            {
                lbNumbers.Enabled = true;
                rbtnServices.Checked = true;
                rbtnCalls.Checked = false;
                rbtnTariffs.Checked = false;
                rbtnPayments.Checked = false;
                initController(_subscriberID);
                initDataGridView();
                Search();
            }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        // TODO: Сдеать, чтобы при нажатии кнопки "Поиск" контроллер переключался на соответствующий выбронному радиобаттону и затем вызывал метод CallsSearch

        // TODO: На этой же форме заодно будут выводиться фамилия, имя, отчество, почта и баланс абонента (без редактирования)

    }
}
