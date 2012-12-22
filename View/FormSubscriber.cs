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
    /// Класс формы заполнения или редактирования данных об абоненте. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormSubscriber : Form
    {
        private ISubscriberController _controller;

        public FormSubscriber(AddSubscriberController controller)
        {
            Text = "Добавление абонента";
            _controller = controller;
            InitializeComponent();
        }

        public FormSubscriber(EditSubscriberController controller)
        {
            Text = "Редактирование абонента";
            InitializeComponent();
            _controller = controller;
            tbName.Text = _controller.getName();
            tbSurname.Text = _controller.getSurname();
            tbPatronymic.Text = _controller.getPatronymic();
            tbEmail.Text = _controller.getEmail();
            tbLogin.Text = _controller.getLogin();
            RefreshNumbers();
        }

        private void RefreshNumbers()
        {
            int ind = lbPnones.SelectedIndex;
            lbPnones.Items.Clear();
            List<string> phoneNumbers = _controller.getPhoneNumbers();
            foreach (string phone in phoneNumbers)
            {
                lbPnones.Items.Add(phone);
            }
            if (lbPnones.Items.Count > ind)
            {
                lbPnones.SelectedIndex = ind;
            }
            else
            {
                lbPnones.SelectedIndex = lbPnones.Items.Count - 1;
            }
        }
        // TODO: Кнопка "Редактировать" должна быть активна, только когда выбран номер телефона
        // TODO: Кнопка "Сбросить пароль" должна быть активна только для существующих пользователей

        private void btnOK_Click(object sender, EventArgs e)
        {
            _controller.ConfirmChanges(tbName.Text, tbPatronymic.Text, tbSurname.Text, tbEmail.Text, tbLogin.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //_controller.Cancel();
            DialogResult = DialogResult.Cancel;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            _controller.ResetPassword();
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if(lbPnones.SelectedIndex >= 0)
                _controller.EditPhoneNumber(lbPnones.SelectedItem.ToString());
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            _controller.AddPhoneNumber();
            RefreshNumbers();
        }

        private void btnDeleteNumber_Click(object sender, EventArgs e)
        {
            if (lbPnones.SelectedIndex >= 0)
                _controller.DeletePhoneNumber(lbPnones.SelectedItem.ToString());
            RefreshNumbers();
        }
    }
}
