using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс цены за услуги связи.
    /// </summary>
    public class Price
    {
        private long _tariffID;

        /// <summary>
        /// Возвращает или задает идентификатор тарифа.
        /// </summary>
        public long TariffID
        {
            get { return _tariffID; }
            set { }
        }

        private string _prefix;

        /// <summary>
        /// Возвращает или задает строку, содержащую префикс телефонного номера.
        /// </summary>
        public string Prefix
        {
            get { return _prefix; }
            set { }
        }

        private double _cost;

        /// <summary>
        /// Возвращает или задает стоимость.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Price, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="tariffID">Идентификатор тарифа</param>
        /// <param name="prefix">Префикс номера телефона</param>
        /// <param name="cost">Стоимость</param>
        public Price(long tariffID, string prefix, float cost)
        {
            _tariffID = tariffID;
            _prefix = prefix;
            _cost = cost;
        }

    }
}
