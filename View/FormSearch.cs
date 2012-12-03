﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddSubscriber();
            Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchResults.CurrentRow != null)
            {
                _controller.EditSubscriber(long.Parse(dataGridViewSearchResults.CurrentRow.Cells[0].Value.ToString()));
                Search();
            }
        }

        private void btnDetailedInf_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearchResults.CurrentRow != null)
            {
                _controller.ShowInfo(long.Parse(dataGridViewSearchResults.CurrentRow.Cells[0].Value.ToString()));
               
            }
            
        }

        private void dataGridViewSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _controller.ShowInfo(long.Parse(dataGridViewSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }
    }
}
