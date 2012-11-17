using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class EditSubscriberController : ISubscriberController
    {
        private Subscriber subscriber;

        public EditSubscriberController(long subscriberID)
        {
            subscriber = DatabaseUtils.SelectSubscriberByID(subscriberID);
        }


        string ISubscriberController.getName()
        {
            if (subscriber != null)
                return subscriber.Name;
            else
                return null;
        }

        string ISubscriberController.getSurname()
        {
            if (subscriber != null)
                return subscriber.Surname;
            else
                return null;
        }

        string ISubscriberController.getPatronymic()
        {
            if (subscriber != null)
                return subscriber.Patronymic;
            else
                return null;
        }

        string ISubscriberController.getEmail()
        {
            if (subscriber != null)
                return subscriber.Email;
            else
                return null;
        }

        string ISubscriberController.getLogin()
        {
            if (subscriber != null)
                return subscriber.Login;
            else
                return null;
        }

        List<string> ISubscriberController.getPhoneNumbers()
        {
            List<PhoneNumber> searchResult = DatabaseUtils.SelectPhoneNumbers(subscriber);
            List<string> result = new List<string>();
            foreach (PhoneNumber n in searchResult)
                result.Add(n.Number);
            return result;
        }

        void ISubscriberController.AddPhoneNumber()
        {
            throw new NotImplementedException();
        }

        void ISubscriberController.EditPhoneNumber(string phoneNumber)
        {
            List<PhoneNumber> searchResult = DatabaseUtils.SelectPhoneNumbers(subscriber);
            foreach (PhoneNumber n in searchResult)
            {
                if (n.Number == phoneNumber.Trim())
                {                   
                    View.FormSelectTariff form = new View.FormSelectTariff(n.ID);
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                    return;
                }
            }
        }


        void ISubscriberController.DeletePhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        void ISubscriberController.ResetPassword()
        {
            DatabaseUtils.ResetSubscriberPassword(subscriber);
        }

        void ISubscriberController.ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name.Trim();
            subscriber.Patronymic = patronymic.Trim();
            subscriber.Surname = surname.Trim();
            subscriber.Email = email.Trim();
            subscriber.Login = login.Trim();
            DatabaseUtils.UpdateSubscriber(subscriber);
        }

        void ISubscriberController.Cancel()
        {
        }
    }
}
