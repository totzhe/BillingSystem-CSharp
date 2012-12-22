using BillingSystem.Controllers;
using BillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem.View
{
    /// <summary>
    /// Класс формы редактирования тарифа. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormTariff : Form
    {
        private ITariffController _controller;

        /// <summary>
        /// Инициализирует новый экземпляр класса FormTariff. Принимает в качестве параметра контроллер добавления тарифа.
        /// </summary>
        /// <param name="controller"></param>
        public FormTariff(AddTariffController controller)
        {
            Text = "Добавление тарифа";           
            InitializeComponent();
            _controller = controller;
            btnSave.Text = "Добавить";
            dgvNameTariff.Visible = false;
            gbInfo.Location = new System.Drawing.Point(12, 12);
            gbInfo.Size = new System.Drawing.Size(700, 407);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса FormTariff. Принимает в качестве параметра контроллер редактирования тарифа.
        /// </summary>
        /// <param name="controller"></param>
        public FormTariff(EditTariffController controller)
        {
            Text = "Редактирование тарифа";
            InitializeComponent();
            _controller = controller;
            btnSave.Text = "Изменить";
            btnImport.Visible = false;
            btnCostDel.Visible = false;
            foreach (Tariff item in _controller.tariff)
            {
                dgvNameTariff.Rows.Add(item.ID, item.Name);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса FormTariff. Принимает в качестве параметра контроллер импорта тарифа.
        /// </summary>
        /// <param name="controller"></param>
        public FormTariff(ImportTariffController controller)
        {
            this.Text = "Импорт тарифа";
            InitializeComponent();
            _controller = controller;
            btnSave.Text = "Добавить";
            dgvNameTariff.Visible = false;
            gbInfo.Location = new System.Drawing.Point(12, 12);
            gbInfo.Size = new System.Drawing.Size(700, 407);
            btnImport.Visible = true;
            gbAddCost.Visible = false;
            btnCostDel.Visible = false;
            gbCost.Location = new System.Drawing.Point(470, 19);
            gbCost.Size = new System.Drawing.Size(219, 352);
            gbDataTarrif.Size = new System.Drawing.Size(457, 352);
            tbName.ReadOnly = true;
            tbDescription.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.Save(tbName.Text, tbDescription.Text, dgvPrice);
            dgvNameTariff.Rows.Clear();
            foreach (Tariff item in _controller.tariff)
            {
                dgvNameTariff.Rows.Add(item.ID, item.Name);
            }
        }

        private void dgvNameTariff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = _controller.tariff[e.RowIndex].Name;
                tbDescription.Text = _controller.tariff[e.RowIndex].Description;
                dgvPrice.Rows.Clear();
                foreach (Price item in _controller.tariff[e.RowIndex].Price)
                {
                    dgvPrice.Rows.Add(item.Prefix, item.Cost);
                }
                _controller.selectTariffId = _controller.tariff[e.RowIndex].ID;
            }
        }

        private void btnCostAdd_Click(object sender, EventArgs e)
        {
            if (tbPrefix.Text != String.Empty && tbPrice.Text != String.Empty)
            {
                dgvPrice.Rows.Add(tbPrefix.Text, tbPrice.Text);
                tbPrefix.Text = String.Empty;
                tbPrice.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Префикс и Цена должны быть заполнены");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<string[]> tariff = _controller.Import(openFileDialog.FileName);
                tbName.Text = tariff[0][0];
                tbDescription.Text = tariff[0][1];
                for (int i = 1; i < tariff.Count; i++)
                {
                    dgvPrice.Rows.Add(tariff[i][0], tariff[i][1]);
                }
            }
        }
    }
}
