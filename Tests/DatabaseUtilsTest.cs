using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BillingSystem.Controllers;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BillingSystem.Tests
{
    [TestFixture]
    public static class DatabaseUtilsTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }
    }
}
