using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers;

namespace BillingSystem.View
{
    /// <summary>
    /// Класс формы редактирования телефонного номера. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormSelectTariff : Form
    {
        private ISelectTariffController _controller;

        /// <summary>
        /// Инициализирует новый класс формы FormSelectTariff, передавая в качестве параметра контроллер выбора тарифа.
        /// </summary>
        /// <param name="controller">Контроллер выбора тарифа</param>
        public FormSelectTariff(ISelectTariffController controller)
        {
            Text = "Редактирование номера";
            _controller = controller;
            InitializeComponent();
            cbTariff.Items.AddRange(_controller.GetActiveTariffs());
            cbTariff.SelectedIndex = 0;
            lblCurrentTariffName.Text = _controller.GetCurrentTariffName();
        }

        private void comboBoxTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = _controller.GetTariffDescription(cbTariff.SelectedItem.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.Confirm(cbTariff.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
            DialogResult = DialogResult.Cancel;
        }
    }
}
