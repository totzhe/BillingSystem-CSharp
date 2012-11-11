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
    // TODO: Кнопка "Редактировать" и "Удалить" должна быть активна, только когда выбран номер телефона

    public partial class FormSubscriber : Form
    {
        private ISubscriberController _controller;

        public FormSubscriber()
        {
            InitializeComponent();
            Text = "Форма добавления пользователя";

            _controller = new AddSubscriberController();
        }

        public FormSubscriber(int subscriberID)
        {
            InitializeComponent();
            Text = "Форма изменения пользователя";
            btnResetPassword.Visible = true;

            _controller = new EditSubscriberController();
        }        

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.ConfirmChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            btnResetPassword.Visible = false;
            labelNewPassword.Visible = true;
            textBoxNewPasword.Visible = true;
        }
    }
}
