using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Other
{
    public class CSVImporter: IFileImporter
    {
        public List<Call> ImportCalls(string filename)
        {
            throw new NotImplementedException();
        }

        public List<Tariff> ImportTariffs(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
