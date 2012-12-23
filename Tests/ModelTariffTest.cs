using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BillingSystem.Controllers;
using BillingSystem.Model;

namespace BillingSystem.Tests
{
    public static class ModelTariffTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void SelectTariffByIDTest(
            [Values(5, 6)]long id)
        {
            Tariff tariff = Tariff.SelectTariffByID(id);
            Assert.IsTrue(tariff.ID == id);
        }

        [Test]
        public static void SelectActiveTariffTest()
        {
            List<Tariff> tariff = Tariff.SelectActiveTariff();
            foreach (Tariff item in tariff)
            {
                Assert.IsTrue(item.Active);
            }
        }

        [Test]
        public static void EditTariffDataTest(
            [Values(13)]long id,
            [Values("Первое", "Второе", "Третье", "Добавленный")]string name,
            [Values("Первое описание", "Второе описание", "Третье описание")]string description)
        {
            Tariff.EditTariffData(id, name, description);
            Tariff tariff = Tariff.SelectTariffByID(id);
            Assert.IsTrue(tariff.ID == id);
            StringAssert.Contains(tariff.Name, name);
            StringAssert.Contains(tariff.Description, description);
        }

        [Test]
        public static void SelectActiveTariffsByNameTest(
            [Values("а", "ы")]string name)
        {
            List<Tariff> tariff = Tariff.SelectActiveTariffsByName(name);
            foreach (Tariff item in tariff)
            {
                StringAssert.Contains(name, item.Name);
            }        
        }

        [Test]
        public static void SelectCallPriceTest(
            [Values(5)]long id,
            [Values("+79601258111")]string number)
        {
            Tariff tariff = Tariff.SelectTariffByID(id);
            Price price = tariff.SelectCallPrice(number);
            Assert.IsTrue(Math.Round(price.Cost, 1).ToString() == "0,1");
        }
        
    }
}
