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

        private List<PhoneNumber> _phonesToUpdate = new List<PhoneNumber>();
        private List<PhoneNumber> _phonesToDelete = new List<PhoneNumber>();
        private List<PhoneNumber> _phonesToAdd = new List<PhoneNumber>();

        public EditSubscriberController(long subscriberID)
        {
            subscriber = DatabaseUtils.SelectSubscriberByID(subscriberID);
        }


        public string getName()
        {
            if (subscriber != null)
                return subscriber.Name;
            else
                return null;
        }

        public string getSurname()
        {
            if (subscriber != null)
                return subscriber.Surname;
            else
                return null;
        }

        public string getPatronymic()
        {
            if (subscriber != null)
                return subscriber.Patronymic;
            else
                return null;
        }

        public string getEmail()
        {
            if (subscriber != null)
                return subscriber.Email;
            else
                return null;
        }

        public string getLogin()
        {
            if (subscriber != null)
                return subscriber.Login;
            else
                return null;
        }

        public List<string> getPhoneNumbers()
        {
            List<PhoneNumber> searchResult = DatabaseUtils.SelectPhoneNumbers(subscriber);
            List<string> result = new List<string>();
            foreach (PhoneNumber n in searchResult)
                result.Add(n.Number);
            foreach (PhoneNumber n in _phonesToAdd)
                result.Add(n.Number);
            foreach (PhoneNumber n in _phonesToDelete)
                result.Remove(n.Number);
            return result;
        }

        public void AddPhoneNumber()
        {
            PhoneNumber number = DatabaseUtils.GetNewNumber();
            number.SubscriberID = subscriber.ID;
            _phonesToAdd.Add(number);
            ISelectTariffController ctcontr = new ChangeTariffController(number);
            View.FormSelectTariff form = new View.FormSelectTariff(ctcontr);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        public void EditPhoneNumber(string phoneNumber)
        {
            List<PhoneNumber> searchResult = DatabaseUtils.SelectPhoneNumbers(subscriber);
            searchResult.AddRange(_phonesToAdd);
            foreach (PhoneNumber n in searchResult)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    _phonesToUpdate.Add(n);
                    ISelectTariffController ctcontr = new ChangeTariffController(n);
                    View.FormSelectTariff form = new View.FormSelectTariff(ctcontr);
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                    return;
                }
            }
        }


        public void DeletePhoneNumber(string phoneNumber)
        {
            List<PhoneNumber> searchResult = DatabaseUtils.SelectPhoneNumbers(subscriber);
            searchResult.AddRange(_phonesToAdd);
            foreach (PhoneNumber n in searchResult)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    _phonesToDelete.Add(n);
                    return;
                }
            }
        }

        public void ResetPassword()
        {
            DatabaseUtils.ResetSubscriberPassword(subscriber);
        }

        public void ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name.Trim();
            subscriber.Patronymic = patronymic.Trim();
            subscriber.Surname = surname.Trim();
            subscriber.Email = email.Trim();
            subscriber.Login = login.Trim();
            DatabaseUtils.UpdateSubscriber(subscriber);
            foreach (PhoneNumber n in _phonesToUpdate)
                DatabaseUtils.UpdatePhoneNumber(n);
            foreach (PhoneNumber n in _phonesToAdd)
                DatabaseUtils.UpdatePhoneNumber(n);
            foreach (PhoneNumber n in _phonesToDelete)
                DatabaseUtils.DeletePhoneNumber(n);
        }

        public void Cancel()
        {
            foreach (PhoneNumber n in _phonesToAdd)
                DatabaseUtils.DeletePhoneNumber(n);
        }
    }
}
