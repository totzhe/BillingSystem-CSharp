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
    public static class ModelPhoneNumberTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void SelectPhoneNumberByIDTest(
            [Values(1, 2, 40)]long id)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByID(id);
            Assert.IsTrue(phoneNumber.ID == id);
        }

        [Test]
        public static void SelectPhoneNumberByNumberTest(
            [Values("+79601258145", "+79601258144", "+79601258143")]string number)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByNumber(number);
            StringAssert.Contains(phoneNumber.Number, number);
        }

        [Test]
        public static void SelectTariffByDateTest(
            [Values("+79601258145")]string number,
            [Values("12.21.2012")]DateTime date)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByNumber(number);
            Tariff tariff = phoneNumber.SelectTariffByDate(date);
            Assert.IsTrue(tariff.ID == 6);
        }

        [Test]
        public static void SelectCallsTest(
            [Values("+79601258144")]string number,
            [Values("12.10.2012")]DateTime from,
            [Values("12.21.2012")]DateTime to)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByNumber(number);
            List<Call> call = phoneNumber.SelectCalls(from, to);
            foreach (Call item in call)
            {
                if (item.CalledNumber == number) { StringAssert.Contains(item.CalledNumber, number); }
                else {
                    if (item.CallingNumber == number) { StringAssert.Contains(item.CallingNumber, number); }
                    else { Assert.Fail(); }
                }
                Assert.IsTrue(item.StartTime >= from);
                Assert.IsTrue(item.StartTime <= to);
            }
        }

        [Test]
        public static void SelectTariffHistoryTest(
            [Values("10.10.2012")]DateTime from,
            [Values("12.21.2012")]DateTime to)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByID(1);
            List<TariffHistory> tariffHistory = phoneNumber.SelectTariffHistory(from, to);
            foreach (TariffHistory item in tariffHistory)
            {
                Assert.IsTrue(item.StartDate >= from);
                Assert.IsTrue(item.StartDate <= to);
            }
        }
        
        [Test]
        public static void GetTariffTest(
            [Values("+79601258145")]string number)
        {
            PhoneNumber phoneNumber = PhoneNumber.SelectPhoneNumberByNumber(number);
            Assert.IsTrue(phoneNumber.GetTariff().ID == 6);
        }
    }
}
