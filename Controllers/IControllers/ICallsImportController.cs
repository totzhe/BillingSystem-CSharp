using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public interface ICallsImportController
    {
        List<Call> _listCall {get; set;}
        void OpenFile(string filename);
        void AddCall();
    }
}
