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
    public static class ModelServiceTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void SelectTariffByDateTest(
            [Values("Смена тарифа", "Оплата звонков")]string name)
        {
            Service service = Service.SelectServiceByName(name);
            StringAssert.Contains(service.Name, name);
        }

        [Test]
        public static void SelectServiceByIDTest(
            [Values(1, 2)]long id)
        {
            Service service = Service.SelectServiceByID(id);
            Assert.IsTrue(service.ID == id);
        }
        
    }
}
