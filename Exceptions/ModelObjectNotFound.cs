using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Exceptions
{
    public class ModelObjectNotFoundException : Exception
    {
        public ModelObjectNotFoundException(string message) : base(message) { }
    }
}
