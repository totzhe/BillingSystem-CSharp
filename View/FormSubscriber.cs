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
            int ind = 0;
            if(dgvPhoneNumbers.CurrentRow != null)
                ind = dgvPhoneNumbers.CurrentRow.Index;
            dgvPhoneNumbers.Rows.Clear();
            List<string[]> items = _controller.getPhoneNumbers();
            foreach (string[] item in items)
            {
                dgvPhoneNumbers.Rows.Add(item);
            }
            if (dgvPhoneNumbers.Rows.Count > ind)
            {
                dgvPhoneNumbers.CurrentCell = dgvPhoneNumbers.Rows[ind].Cells[0];
            }
            else
            {
                dgvPhoneNumbers.CurrentCell = dgvPhoneNumbers.Rows[dgvPhoneNumbers.Rows.Count].Cells[0];
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
            DialogResult = DialogResult.Cancel;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            _controller.ResetPassword();
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if (dgvPhoneNumbers.CurrentRow != null)
            {
                _controller.EditPhoneNumber(dgvPhoneNumbers.CurrentRow.Cells[0].Value.ToString());
                RefreshNumbers();
            }
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            _controller.AddPhoneNumber();
            RefreshNumbers();
        }

        private void btnDeleteNumber_Click(object sender, EventArgs e)
        {
            if (dgvPhoneNumbers.CurrentRow != null)
                _controller.DeletePhoneNumber(dgvPhoneNumbers.CurrentRow.Cells[0].Value.ToString());
            RefreshNumbers();
        }
    }
}
