using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Other
{
    public class CSVExporter : IFileExporter
    {
        public void ExportCalls(string filename, string phoneNumber, DateTime beginningDate, DateTime endDate, List<string[]> items)
        {
            throw new NotImplementedException();
        }

        public void ExportOperations(string filename, string phoneNumber, DateTime beginningDate, DateTime endDate, List<string[]> items)
        {
            throw new NotImplementedException();
        }

        public void ExportDebtors(string filename, DateTime date, List<string[]> items)
        {
            throw new NotImplementedException();
        }
    }
}
