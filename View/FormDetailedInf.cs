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
    /// <summary>
    /// Класс формы детализированной информации. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormDetailedInf : Form
    {
        private IDetailedInfController _controller;
        private long _subscriberID;

        /// <summary>
        /// Инициализирует новый экземпляр класса FormDetailedInf, получая в качестве параметра идентификатор абонента 
        /// </summary>
        /// <param name="subscriberId">Идентификатор абонента</param>
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

        /// <summary>
        /// Инициализирует баланс для данного абонента.
        /// </summary>
        private void initBalance()
        {
            lblBalance.Text = _controller.GetBalance();
            lblFromBalance.Text = _controller.GetBalanceByDate(dtpFrom.Value);
            lblToBalance.Text = _controller.GetBalanceByDate(dtpTo.Value);
        }

        /// <summary>
        /// Инициализацирует контроллер детализированной информации в зависимости от выбранного компонента типа RadioButton. Принимает в качестве аргумента идентификаор абонента.
        /// </summary>
        /// <param name="subscriberId">Идентификатор</param>
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

        /// <summary>
        /// Осуществляет поиск по заданным критериям.
        /// </summary>
        private void Search()
        {
            List<string[]> items = _controller.Search(lbNumbers.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value);
            dgvInf.Rows.Clear();
            foreach (string[] item in items)
            {
                dgvInf.Rows.Add(item);
            }
        }

        /// <summary>
        /// Инициализирует таблицу, содержащую детализированную информацио в зависимости от выбранного компонента RadioButton.
        /// </summary>
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
            }
            if (rbtnTariffs.Checked == true)
            {
                dgvInf.Rows.Clear();
                dgvInf.Columns.Clear();
                dgvInf.ColumnCount = 6;
                dgvInf.Columns[0].Name = "Дата подключения";
                dgvInf.Columns[1].Name = "Время подключения";
                dgvInf.Columns[2].Name = "Тарифный план";
                dgvInf.Columns[3].Name = "Дата отключения";
                dgvInf.Columns[4].Name = "Время отключения";
                dgvInf.Columns[5].Name = "Стоимость";
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
                dgvInf.Columns[2].Name = "Услуга";
                dgvInf.Columns[3].Name = "Стоимость";
            }
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Search();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string fn = string.Empty;

            saveFileDialog.Title = "Сохранить";
            saveFileDialog.Filter = "CSV (разделители - точки с запятыми)|*.csv|HTML-страницы (*.html)|*.html";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = fn;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fn = saveFileDialog.FileName;
                if (saveFileDialog.FilterIndex == 1 && fn != string.Empty)
                {
                    FileExporter.DGVtoCSV(dgvInf, fn);
                }
                if (saveFileDialog.FilterIndex == 2 && fn != string.Empty)
                {
                    FileExporter.DetailedInfToHtml(dgvInf, dtpFrom.Value, dtpTo.Value, this.Text, lbNumbers.SelectedItem.ToString(), _controller.TotalSum, fn);
                }
            }
        }

        private void dtpFrom_CloseUp(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpFrom.Value.Date;
            initBalance();
            Search();
        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {  
            dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(59);
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

        // TODO: Сдеать, чтобы при нажатии кнопки "Поиск" контроллер переключался на соответствующий выбронному радиобаттону и затем вызывал метод CallsSearch

        // TODO: На этой же форме заодно будут выводиться фамилия, имя, отчество, почта и баланс абонента (без редактирования)

    }
}