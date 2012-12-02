using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public abstract class SubscriberController : ISubscriberController
    {
        protected Subscriber subscriber;

        protected HashSet<PhoneNumber> _phonesToUpdate = new HashSet<PhoneNumber>();
        protected HashSet<PhoneNumber> _phonesToDelete = new HashSet<PhoneNumber>();
        protected HashSet<PhoneNumber> _phonesToAdd = new HashSet<PhoneNumber>();
        private List<PhoneNumber> _phones = null;

        protected List<PhoneNumber> phones
        {
            get
            {
                if (_phones == null)
                    _phones = subscriber.GetPhoneNumbers();
                return _phones;
            }
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

        public SubscriberController()
        {
            subscriber = Subscriber.GetNewSubscriber();
        }

        public SubscriberController(long subscriberID)
        {
            subscriber = Subscriber.SelectSubscriberByID(subscriberID);
            if (subscriber == null)
                throw new BillingSystem.Exceptions.ModelObjectNotFoundException("Subscriber with id = " + subscriberID + " doesn't exist");
        }

        public virtual List<string> getPhoneNumbers()
        {
            List<string> result = new List<string>();
            foreach (PhoneNumber n in phones)
                result.Add(n.Number);
            foreach (PhoneNumber n in _phonesToAdd)
                result.Add(n.Number);
            foreach (PhoneNumber n in _phonesToDelete)
                result.Remove(n.Number);
            return result;
        }

        public virtual void AddPhoneNumber()
        {
            PhoneNumber number = PhoneNumber.GetNewNumber();
            number.SubscriberID = subscriber.ID;
            _phonesToAdd.Add(number);
            ISelectTariffController ctcontr = new ChangeTariffController(number);
            View.FormSelectTariff form = new View.FormSelectTariff(ctcontr);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        public virtual void EditPhoneNumber(string phoneNumber)
        {
            foreach (PhoneNumber n in phones)
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
            foreach (PhoneNumber n in _phonesToAdd)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    //_phonesToUpdate.Add(n);
                    ISelectTariffController ctcontr = new ChangeTariffController(n);
                    View.FormSelectTariff form = new View.FormSelectTariff(ctcontr);
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                    return;
                }
            }
        }


        public virtual void DeletePhoneNumber(string phoneNumber)
        {
            foreach (PhoneNumber n in phones)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    _phonesToDelete.Add(n);
                    _phonesToUpdate.Remove(n);
                    return;
                }
            }
            foreach (PhoneNumber n in _phonesToAdd)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    _phonesToAdd.Remove(n);
                    _phonesToUpdate.Remove(n);
                    break;
                }
            }
        }

        public virtual void ResetPassword()
        {
            subscriber.ResetPassword();
        }

        public virtual void ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name == null ? null : name.Trim();
            subscriber.Patronymic = patronymic == null ? null : patronymic.Trim();
            subscriber.Surname = surname == null ? null : surname.Trim();
            subscriber.Email = email == null ? null : email.Trim();
            subscriber.Login = login == null ? null : login.Trim();
            subscriber.Update();
            foreach (PhoneNumber n in _phonesToUpdate)
                n.Update();
            foreach (PhoneNumber n in _phonesToAdd)
                n.Add();
            foreach (PhoneNumber n in _phonesToDelete)
                n.Delete();
        }

        public virtual void Cancel()
        {
        }
    }
}
