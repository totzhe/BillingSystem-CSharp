using System;
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
    public partial class FormSearch : Form
    {
        private ISearchController _controller;

        public FormSearch()
        {
            _controller = new SearchController();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearchResults.Rows.Clear();
            List<string[]> _items = _controller.Search(textBoxName.Text, textBoxPatronymic.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, textBoxDebt.Text);
            foreach (string[] item in _items)
            {
                dataGridViewSearchResults.Rows.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddSubscriber();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _controller.EditSubscriber(0);
        }

        private void btnDetailedInf_Click(object sender, EventArgs e)
        {
            _controller.ShowInfo(0);
        }
    }
}
