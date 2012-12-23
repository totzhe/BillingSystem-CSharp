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
    public static class ModelSubscriberTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void SelectSubscribersTest(
            [Values("Иван", "Test", "")]string name,
            [Values("Иванович", "Tested", "")]string patronymic,
            [Values("Иванов", "Tester", "")]string surname,
            [Values("")]string phoneNumber,
            [Values(0, 0)]double debt)
        {
            List<Subscriber> result = Subscriber.SelectSubscribers(name, patronymic, surname, phoneNumber, debt);
            foreach (Subscriber subscriber in result)
            {
                if (name != string.Empty)
                {
                    StringAssert.Contains(subscriber.Name, name);
                }
                if (surname != string.Empty)
                {
                    StringAssert.Contains(subscriber.Surname, surname);
                }
                if (patronymic != string.Empty)
                {
                    StringAssert.Contains(subscriber.Patronymic, patronymic);
                }
                if (debt > 0)
                {
                    Assert.IsTrue(subscriber.Balance >= debt);
                }
            }
        }

        [Test]
        public static void SelectSubscriberByIDTest(
            [Values(1, 2, 3)]long id)
        {
            Subscriber subscriber = Subscriber.SelectSubscriberByID(id);
            Assert.IsTrue(subscriber.ID == id);
        }

        [Test]
        public static void GetPhoneNumbersTest(
            [Values(1)]long id)
        {
            Subscriber subscriber = Subscriber.SelectSubscriberByID(id);
            List<PhoneNumber> phoneNumber = subscriber.GetPhoneNumbers();
            StringAssert.Contains(phoneNumber[0].Number, "+79503468221");
            StringAssert.Contains(phoneNumber[1].Number, "+79601258111");
        }

        [Test]
        public static void GetBalanceByDateTest(
            [Values("12.10.2012")]DateTime date)
        {
            Subscriber subscriber = Subscriber.SelectSubscriberByID(1);
            StringAssert.Contains(Math.Round(subscriber.GetBalanceByDate(date), 1).ToString(), "-159,7");
        }

        [Test]
        public static void DepositMoneyTest(
            [Values(1, 3, 5)]long sum)
        {
            Subscriber subscriber = Subscriber.SelectSubscriberByID(1);
            double balance_now = subscriber.Balance;
            subscriber.DepositMoney(sum);
            Assert.IsTrue(balance_now + sum == subscriber.Balance);
        }
        
    }
}
