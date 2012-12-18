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
    public partial class FormEditTariff : Form
    {
        private IEditTariffController _controller;

        /// <summary>
        /// инициализирует новый экземпляр класса FormEditTariff. Принимает в качестве параметра контроллер редактирования тарифа.
        /// </summary>
        /// <param name="controller">Контроллер</param>
        public FormEditTariff(EditTariffController controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
