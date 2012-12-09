using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;
using BillingSystem.View;

namespace BillingSystem.Controllers
{
    public class CallsImportController : ICallsImportController 
    {
        public List<Call> _listCall { get; set; }

        public void OpenFile(string filename)
        {
            _listCall = new List<Call>();
            
            List<string[]> _items = FileExporter.CSVtoList(filename);
            foreach (string[] item in _items)
            {
                _listCall.Add(new Call(null, item[0], item[1], DateTime.Parse(item[2]), DateTime.Parse(item[3])));
            }
        }

        public void AddCall()
        {
            foreach (Call item in _listCall)
            {
                item.Add();
            }
        }
    }
}
