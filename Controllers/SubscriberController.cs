using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Абстрактный класс контроллера абонента. Реализует интерфейс BillingSystem.Controllers.IControllers.ISubscriberController. 
    /// </summary>
    public abstract class SubscriberController : ISubscriberController
    {
        /// <summary>
        /// Абонент.
        /// </summary>
        protected Subscriber subscriber;

        /// <summary>
        /// Телефонные номера для редактирования.
        /// </summary>
        protected HashSet<PhoneNumber> _phonesToUpdate = new HashSet<PhoneNumber>();
        
        /// <summary>
        /// Телефонные номера для удаления.
        /// </summary>
        protected HashSet<PhoneNumber> _phonesToDelete = new HashSet<PhoneNumber>();
        
        /// <summary>
        /// Телефонные номера для добавления.
        /// </summary>
        protected HashSet<PhoneNumber> _phonesToAdd = new HashSet<PhoneNumber>();
        
        private List<PhoneNumber> _phones = null;

        /// <summary>
        /// Получает список имеющихся у абонента телефонных номеров.
        /// </summary>
        protected List<PhoneNumber> phones
        {
            get
            {
                if (_phones == null)
                    _phones = subscriber.GetPhoneNumbers();
                return _phones;
            }
        }

        /// <summary>
        /// Возвращает имя абонента.
        /// </summary>
        /// <returns>Имя</returns>
        public string getName()
        {
            if (subscriber != null)
                return subscriber.Name;
            else
                return null;
        }

        /// <summary>
        /// Возвращает фамилию абонента.
        /// </summary>
        /// <returns>Фамилия</returns>
        public string getSurname()
        {
            if (subscriber != null)
                return subscriber.Surname;
            else
                return null;
        }

        /// <summary>
        /// Возвращает отчество абонента.
        /// </summary>
        /// <returns>Отчество</returns>
        public string getPatronymic()
        {
            if (subscriber != null)
                return subscriber.Patronymic;
            else
                return null;
        }

        /// <summary>
        /// Возвращает адрес электронной почты абонента.
        /// </summary>
        /// <returns>Адрес электронной почты</returns>
        public string getEmail()
        {
            if (subscriber != null)
                return subscriber.Email;
            else
                return null;
        }

        /// <summary>
        /// Возвращает логин абонента.
        /// </summary>
        /// <returns>Логин</returns>
        public string getLogin()
        {
            if (subscriber != null)
                return subscriber.Login;
            else
                return null;
        }

        /// <summary>
        /// Создает новый экземпляр класса Subscriber.
        /// </summary>
        public SubscriberController()
        {
            subscriber = Subscriber.GetNewSubscriber();
        }

        /// <summary>
        /// Создает новый экземпляр класса Subscriber с указанным параметром:
        /// </summary>
        /// <param name="subscriberID">ID абонента</param>
        public SubscriberController(long subscriberID)
        {
            subscriber = Subscriber.SelectSubscriberByID(subscriberID);
            if (subscriber == null)
                throw new BillingSystem.Exceptions.ModelObjectNotFoundException("Subscriber with id = " + subscriberID + " doesn't exist");
        }

        /// <summary>
        /// Возвращает номера телефонов абонента.
        /// </summary>
        /// <returns>Номера телефонов</returns>
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

        /// <summary>
        /// Добавляет телефонный номер.
        /// </summary>
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

        /// <summary>
        /// Редактирует телефонный номер.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
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

        /// <summary>
        /// Удаляет телефонный номер.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
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

        /// <summary>
        /// Сбрасывает пароль.
        /// </summary>
        public virtual void ResetPassword()
        {
            subscriber.ResetPassword();
        }

        /// <summary>
        /// Подтверждает изменения для абонента:
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="email">Адрес электронной почты</param>
        /// <param name="login">Логин</param>
        public abstract void ConfirmChanges(string name, string patronymic, string surname, string email, string login);

        /// <summary>
        /// Отмена действий.
        /// </summary>
        public virtual void Cancel()
        {
        }
    }
}
