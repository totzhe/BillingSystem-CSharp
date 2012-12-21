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

namespace BillingSystem
{
    /// <summary>
    /// Класс формы поиска абонентов. Наследует класс System.Windows.Forms.Form. 
    /// </summary>
    public partial class FormSearch : Form
    {
        private ISearchController _controller;

        /// <summary>
        /// Инициализирует новый экземпляр класа FormSearch
        /// </summary>
        public FormSearch()
        {
            _controller = new SearchController();
            InitializeComponent();
            Search();
        }

        /// <summary>
        /// Осуществляет поиск абонентов.
        /// </summary>
        private void Search()
        {
            dataGridViewSearchResults.Rows.Clear();
            List<string[]> _items = _controller.Search(textBoxName.Text, textBoxPatronymic.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, textBoxDebt.Text);
            foreach (string[] item in _items)
            {
                dataGridViewSearchResults.Rows.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridViewSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _controller.ShowInfo(long.Parse(dataGridViewSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void tsmCallsImport_Click(object sender, EventArgs e)
        {
            _controller.ShowCallsImport();
        }

        private void tsmDeposit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchResults.CurrentRow != null)
            {
                _controller.Deposit(long.Parse(dataGridViewSearchResults.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void tsmAddTariff_Click(object sender, EventArgs e)
        {
            _controller.ShowAddTariff();
        }

        

        private void tsmCharge_Click(object sender, EventArgs e)
        {
            _controller.ChargeCalls();
        }

        private void tsmInfoSubscriber_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchResults.CurrentRow != null)
            {
                _controller.ShowInfo(long.Parse(dataGridViewSearchResults.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void tsmEditSubscriber_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchResults.CurrentRow != null)
            {
                _controller.EditSubscriber(long.Parse(dataGridViewSearchResults.CurrentRow.Cells[0].Value.ToString()));
                Search();
            }
        }

        private void tsmAddSubscriber_Click(object sender, EventArgs e)
        {
            _controller.AddSubscriber();
            Search();
        }

        private void tsmSaveToCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "Текстовый файл|*.csv";
            saveFileDialog.Title = "Сохранить";

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != string.Empty)
            {
                FileExporter.DGVtoCSV(dataGridViewSearchResults, saveFileDialog.FileName);
            }
        }

        private void tsmMonthlyInfo_Click(object sender, EventArgs e)
        {
            _controller.ShowMonthlyInfo();
        }

        private void импортТарифовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowImportTariff();
        }

        private void tsmiAddTariff_Click(object sender, EventArgs e)
        {
            _controller.ShowAddTariff();
        }

        private void tsmiTariffImport_Click(object sender, EventArgs e)
        {
            _controller.ShowImportTariff();
        }

        private void tsmEditTariff_Click(object sender, EventArgs e)
        {
            _controller.ShowEditTariff();
        }
    }
}
