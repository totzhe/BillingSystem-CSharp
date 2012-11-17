using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Controllers;
//using BillingSystem.Model;

namespace BillingSystem.View
{
    public partial class FormSubscriber : Form
    {
        private ISubscriberController _controller;

        public FormSubscriber()
        {
            //здесь - контроллер AddSubscriberController
            InitializeComponent();
        }

        public FormSubscriber(long subscriberID)
        {
            //здесь - контроллер EditSubscriberController
            InitializeComponent();
            _controller = new EditSubscriberController(subscriberID);
            List<string> phoneNumbers = _controller.getPhoneNumbers();
            textBoxName.Text = _controller.getName();
            textBoxSurname.Text = _controller.getSurname();
            textBoxPatronymic.Text = _controller.getPatronymic();
            textBoxEmail.Text = _controller.getEmail();
            textBoxLogin.Text = _controller.getLogin();
            foreach (string phone in phoneNumbers)
            {
                listBoxPhoneNumbers.Items.Add(phone);
            }
        }
        // TODO: Кнопка "Редактировать" должна быть активна, только когда выбран номер телефона
        // TODO: Кнопка "Сбросить пароль" должна быть активна только для существующих пользователей

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.ConfirmChanges(textBoxName.Text, textBoxPatronymic.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxLogin.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            _controller.ResetPassword();
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if(listBoxPhoneNumbers.SelectedIndex >= 0)
                _controller.EditPhoneNumber(listBoxPhoneNumbers.SelectedItem.ToString());
        }
    }
}
