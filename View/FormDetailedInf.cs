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
    public partial class FormDetailedInf : Form
    {
        private IDetailedInfController _controler;
        public FormDetailedInf(int id)
        {
            //_subscriber = //получить из БД
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _controler.Search(dateTimePickerFrom.Value, dateTimePickerTo.Value, listBoxPhoneNumbers.SelectedItem.ToString());
        }
        // TODO: Сдеать, чтобы при нажатии кнопки "Поиск" контроллер переключался на соответствующий выбронному радиобаттону и затем вызывал метод Search

        // TODO: На этой же форме заодно будут выводиться фамилия, имя, отчество, почта и баланс абонента (без редактирования)

    }
}
