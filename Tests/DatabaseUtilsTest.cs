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

        [Test]
        public static void SelectTariffByIDTest()
        {
            StringAssert.Contains(DatabaseUtils.SelectTariffByID(5).Name.ToLower(), "Базовый".ToLower());
        }
    }
}
