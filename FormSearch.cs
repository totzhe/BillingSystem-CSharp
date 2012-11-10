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

        private List<string[]> _items;

        public FormSearch()
        {
            _controller = new SearchController();
            //dataGridViewSearchResults.Rows.Add;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            double debt = -1;
            if (textBoxDebt.Text != string.Empty)
            {
                try
                {
                    debt = double.Parse(textBoxDebt.Text);
                }
                catch (FormatException exc)
                {
                    MessageBox.Show("Введено неверное значение для размера задолженности.");
                }
            }
            _items = _controller.Search(textBoxName.Text, textBoxPatronymic.Text, textBoxSurname.Text, textBoxPhoneNumber.Text, debt);
            dataGridViewSearchResults.Rows.Clear();
            foreach (string[] s in _items)
                dataGridViewSearchResults.Rows.Add(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddSubscriber();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _controller.EditSubscriber(0);//получить ID из выбранной строки таблицы
        }

        private void btnDetailedInf_Click(object sender, EventArgs e)
        {
            _controller.ShowInfo(0);//получить ID из выбранной строки таблицы
        }
    }
}
