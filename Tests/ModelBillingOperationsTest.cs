using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BillingSystem.Controllers;
using BillingSystem.Model;

namespace BillingSystem.Tests
{
    [TestFixture]
    public static class ModelBillingOperationsTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void CalculateCallCostTest(
            [Values("+79601258111")]string callingNumber,
            [Values("+79503468221")]string calledNumber,
            [Values("12.10.2012 11:13")]DateTime startTime,
            [Values("12.10.2012 11:15")]DateTime endTime)
        {
            Call call = new Call(calledNumber, calledNumber, startTime, endTime);
            Tariff tariff = Tariff.SelectTariffByID(6);
            StringAssert.Contains(BillingOperations.CalculateCallCost(call, tariff).ToString(), "48");
        }

        [Test]
        public static void CalculateCallsChargesTest(
            [Values("11.1.2012")]DateTime from,
            [Values("11.30.2012 23:59")]DateTime to)
        {
            List<Charge> charge = BillingOperations.CalculateCallsCharges(from, to);
            StringAssert.Contains(Math.Round(charge[0].Sum, 1).ToString(), "19,7");
            StringAssert.Contains(Math.Round(charge[1].Sum, 1).ToString(), "1026");
        }

    }
}
