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
    /// Класс формы импорта телефонных звонков. Наследует класс System.Windows.Forms.Form.
    /// </summary>
    public partial class FormCallsImport : Form
    {
        private ICallsImportController _controller;

        /// <summary>
        /// Инициализирует новый экземпляр класса FormCallsImport, получая в качестве параметра объект класса CallsImportController.
        /// </summary>
        /// <param name="controller">Контроллер импорта звонков</param>
        public FormCallsImport(CallsImportController controller)
        {
            _controller = controller;
            
            InitializeComponent();
        }

        /// <summary>
        /// Событие, обрабатываемое при нажатии на кнопку "Открыть...".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string fn = string.Empty;

            openFileDialog.FileName = fn;
            openFileDialog.DefaultExt = "csv";
            openFileDialog.Filter = "Текстовый файл|*.csv";
            openFileDialog.Title = "Открыть";
            openFileDialog.Multiselect = false;
            
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fn = openFileDialog.FileName;
                this.Text = fn;
                dgvImportCalls.Rows.Clear();
                _controller.OpenFile(fn);
                foreach (Dictionary<string, string> item in _controller.GetCalls())
                {
                    dgvImportCalls.Rows.Add(item[Constants.Outgoing], item[Constants.Incoming], item[Constants.StartTime], item[Constants.EndTime]);
                }
            }
        }

        /// <summary>
        /// Событие, обрабатываемое при нажатии на кнопку "Добавить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddCall();
            dgvImportCalls.Rows.Clear();
        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            _controller.RndCall(10);
            dgvImportCalls.Rows.Clear();
            foreach (Dictionary<string, string> item in _controller.GetCalls())
            {
                dgvImportCalls.Rows.Add(item[Constants.Outgoing], item[Constants.Incoming], item[Constants.StartTime], item[Constants.EndTime]);
            }
        }

       
    }
}
