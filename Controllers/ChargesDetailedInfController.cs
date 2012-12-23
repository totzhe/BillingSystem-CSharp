using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера детализированной информации о списаниях. Наследует класс BillingSystem.Controllers.DetailedInfController.
    /// </summary>
    class ChargesDetailedInfController : DetailedInfController
    {
        private double _totalSum = 0;

        /// <summary>
        /// Полная стоимость
        /// </summary>
        public override double TotalSum
        {
            get { return _totalSum; }
            set { _totalSum = value; }
        }
        
        /// <summary>
        /// Создает экземпляр класса ChargesDetailedInfController.
        /// </summary>
        /// <param name="subscriberID">Идентификатор абонента</param>
        public ChargesDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        /// <summary>
        /// Возвращает детализированную информацию о списаниях по указанным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="from">Начало периода</param>
        /// <param name="to">Конец периода</param>
        /// <returns>Информация о списаниях</returns>
        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber phone = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Charge> charges = phone.SelectCharges(from, to);
            List<string[]> result = new List<string[]>();
            foreach (Charge c in charges)
            {
                string [] item = new string[4];
                item[0] = c.Date.ToShortDateString();
                item[1] = c.Date.ToLongTimeString();
                item[2] = c.GetService().Name;
                item[3] = Math.Round(c.Sum, 2).ToString() + " " + Constants.Currency;
                _totalSum += Math.Round(c.Sum, 2);
                result.Add(item);
            }
            return result;
        }
    }
}
