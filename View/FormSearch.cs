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
    /// Главная форма проекта
    /// </summary>
    public partial class FormSearch : Form
    {
        private ISearchController _controller;

        public FormSearch()
        {
            _controller = new SearchController();
            InitializeComponent();
            Search();
        }

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

        private void tsmEditTariff_Click(object sender, EventArgs e)
        {
            _controller.ShowEditTariff();
        }

        private void tsmCharge_Click(object sender, EventArgs e)
        {
            BillingSystem.Model.BillingOperations.ChargeCalls();
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
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                FileExporter.DGVtoCSV(dataGridViewSearchResults, saveFileDialog.FileName);
            }
        }
    }
}
