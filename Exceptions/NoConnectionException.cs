using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Exceptions
{
    public class NoConnectionException : Exception
    {
        public NoConnectionException(string message) : base(message) { }
    }
}
