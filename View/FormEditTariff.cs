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
    public partial class FormEditTariff : Form
    {
        private IEditTariffController _controller;

        public FormEditTariff(EditTariffController controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
