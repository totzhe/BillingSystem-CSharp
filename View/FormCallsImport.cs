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
    public partial class FormCallsImport : Form
    {
        private ICallsImportController _controller;
       

        public FormCallsImport(CallsImportController controller)
        {
            _controller = controller;
            
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _controller.OpenFile(openFileDialog.FileName);
                foreach (Call item in _controller._listCall)
                {
                    dgvImportCalls.Rows.Add(item.CallingNumber, item.CalledNumber, item.StartTime, item.EndTime);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddCall();
        }

       
    }
}
