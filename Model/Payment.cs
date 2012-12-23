using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс платежа.
    /// </summary>
    public class Payment
    {
        private long _id;

        /// <summary>
        /// Возвращает идентификатор платежа.
        /// </summary>
        public long ID
        {
            get { return _id; }
        }

        private long _subscriberID;

        /// <summary>
        /// Возвращает идентификатор абонента, на счет которого поступил платеж.
        /// </summary>
        public long SubscriberID
        {
            get { return _subscriberID; }
        }

        private double _sum;

        /// <summary>
        /// Возвращает сумму платежа.
        /// </summary>
        public double Sum
        {
            get { return _sum; }
        }

        private DateTime _date;

        /// <summary>
        /// Дата платежа.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Payment, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="subscriber">Абонент</param>
        /// <param name="sum">Сумма</param>
        public Payment(Subscriber subscriber, double sum)
        {
            _date = System.DateTime.Now;
            _subscriberID = subscriber.ID;
            _sum = sum;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Payment, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="id">Идентификатор платежа</param>
        /// <param name="subscriberID">идентификатор абонента</param>
        /// <param name="sum">Сумма</param>
        /// <param name="paymentDate">Дата платежа</param>
        public Payment(long id, long subscriberID, double sum, DateTime paymentDate)
        {
            _id = id;
            _subscriberID = subscriberID;
            _sum = sum;
            _date = paymentDate;
        }
    }
}
