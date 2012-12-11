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
                dgvImportCalls.Rows.Clear();
                _controller.OpenFile(openFileDialog.FileName);
                foreach (Dictionary<string, string> item in _controller.GetCalls())
                {
                    dgvImportCalls.Rows.Add(item["CallingNumber"], item["CalledNumber"], item["StartTime"], item["EndTime"]);
                }
            }
        }

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
                dgvImportCalls.Rows.Add(item["CallingNumber"], item["CalledNumber"], item["StartTime"], item["EndTime"]);
            }
        }

       
    }
}
