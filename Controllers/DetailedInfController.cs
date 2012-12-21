using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;
using BillingSystem.Controllers.IControllers;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Абстрактный класс детализированной информации. Реализует интерфейс BillingSystem.Controllers.IControllers.IDetailedInfController.
    /// </summary>
    public abstract class DetailedInfController : IDetailedInfController
    {
        protected Subscriber _subscriber;

        /// <summary>
        /// Конструктор контроллера детализированной информации.
        /// </summary>
        /// <param name="subscriberID">ID абонента</param>
        public DetailedInfController(long subscriberID)
        {
            _subscriber = Subscriber.SelectSubscriberByID(subscriberID);
            if (_subscriber == null)
                throw new BillingSystem.Exceptions.ModelObjectNotFoundException("Subscriber with number = " + subscriberID);
        }

        /// <summary>
        /// Возвращает ФИО абонента.
        /// </summary>
        /// <returns>ФИО.</returns>
        public virtual string GetSubscriberFullName()
        {
            if (_subscriber != null)
            {
                return _subscriber.GetFullName();
            }
            else
                return null;
        }

        /// <summary>
        /// Возвращает список имеющихся у абонента телефонных номеров.
        /// </summary>
        /// <returns>Телефонные номера</returns>
        public virtual List<string> GetPhoneNumbers()
        {
            List<PhoneNumber> searchResult = _subscriber.GetPhoneNumbers();
            List<string> result = new List<string>();
            foreach (PhoneNumber n in searchResult)
                result.Add(n.Number);
            return result;
        }

        /// <summary>
        /// Возвращает баланс по состоянию на указанную дату.
        /// </summary>
        /// <param name="date">Конкретная дата и время</param>
        /// <returns></returns>
        public string GetBalanceByDate(DateTime date)
        {
            return Math.Round(_subscriber.GetBalanceByDate(date), 2).ToString() + " " + Constants.Currency;
        }

        /// <summary>
        /// Возвращает текущий баланс абонента.
        /// </summary>
        /// <returns>Баланс</returns>
        public string GetBalance()
        {
            return Math.Round(_subscriber.Balance, 2).ToString() + " " + Constants.Currency;
        }

        /// <summary>
        /// Возвращает детализированную информацию по указанным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="from">Начало периода</param>
        /// <param name="to">Конец периода</param>
        /// <returns>Детализированная информация</returns>
        public abstract List<string[]> Search(string phoneNumber, DateTime from, DateTime to);

        public abstract double TotalSum
        {
            get;
        }

    }
}