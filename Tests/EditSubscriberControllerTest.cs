using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BillingSystem.Controllers;

namespace BillingSystem.Tests
{
    [TestFixture]
    public static class EditSubscriberControllerTest
    {
        [TestFixtureSetUp]
        public static void Connect()
        {
            DatabaseUtils.Connect(Constants.ConnectionString);
        }

        [Test]
        public static void NormalConditionsTest()
        {
            DatabaseUtils.Connect(@"server=vragov.com;userid=billing;password=billing;database=billing;charset=utf8");
            EditSubscriberController controller = new EditSubscriberController(1);
            controller.ConfirmChanges("Name", "Patronymic", "Surname", "mailbox@email.com", "Login");
            StringAssert.AreEqualIgnoringCase("Name", controller.getName());
            StringAssert.AreEqualIgnoringCase("Patronymic", controller.getPatronymic());
            StringAssert.AreEqualIgnoringCase("Surname", controller.getSurname());
            StringAssert.AreEqualIgnoringCase("mailbox@email.com", controller.getEmail());
            StringAssert.AreEqualIgnoringCase("Login", controller.getLogin());
            controller.ConfirmChanges("N", "P", "S", "m", "L");
            StringAssert.AreEqualIgnoringCase("N", controller.getName());
            StringAssert.AreEqualIgnoringCase("P", controller.getPatronymic());
            StringAssert.AreEqualIgnoringCase("S", controller.getSurname());
            StringAssert.AreEqualIgnoringCase("m", controller.getEmail());
            StringAssert.AreEqualIgnoringCase("L", controller.getLogin());
            controller.ConfirmChanges("Name", "Patronymic", "Surame", "mailbox@email.com", "Login");
        }

        [Test]
        [ExpectedExceptionAttribute("BillingSystem.Exceptions.ModelObjectNotFoundException")]
        public static void NotExistingSubscriberTest()
        {
            DatabaseUtils.Connect(@"server=vragov.com;userid=billing;password=billing;database=billing;charset=utf8");
            EditSubscriberController controller = new EditSubscriberController(-1);
            /*controller.ConfirmChanges("Name", "Patronymic", "Surname", "mailbox@email.com", "Login");
            StringAssert.AreEqualIgnoringCase(null, controller.getName());
            StringAssert.AreEqualIgnoringCase(null, controller.getPatronymic());
            StringAssert.AreEqualIgnoringCase(null, controller.getSurname());
            StringAssert.AreEqualIgnoringCase(null, controller.getEmail());
            StringAssert.AreEqualIgnoringCase(null, controller.getLogin());
            controller.ConfirmChanges("N", "P", "S", "m", "L");
            StringAssert.AreEqualIgnoringCase(null, controller.getName());
            StringAssert.AreEqualIgnoringCase(null, controller.getPatronymic());
            StringAssert.AreEqualIgnoringCase(null, controller.getSurname());
            StringAssert.AreEqualIgnoringCase(null, controller.getEmail());
            StringAssert.AreEqualIgnoringCase(null, controller.getLogin());
            controller.ConfirmChanges("Name", "Patronymic", "Surame", "mailbox@email.com", "Login");*/
        }
    }
}
