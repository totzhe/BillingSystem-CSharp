using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс котроллера детализированной информации о платежах. Наследует класс BillingSystem.Controllers.DetailedInfController.
    /// </summary>
    class PaymentsDetailedInfController : DetailedInfController
    {
        private double _totalSum = 0;

        /// <summary>
        /// Полная стоимость
        /// </summary>
        public override double TotalSum
        {
            get
            { 
                return _totalSum;
            }
        }
        
        /// <summary>
        /// Создает экземпляр класса PaymentsDetailedInfController. 
        /// </summary>
        /// <param name="subscriberID">ID абонента</param>
        public PaymentsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        /// <summary>
        /// Возвращает детализированную информацию о платежах по указанным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="from">Начало периода</param>
        /// <param name="to">Конец периода</param>
        /// <returns>Детализированная информация</returns>
        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Payment> payments = _subscriber.SelectPayments(from, to);
            List<string[]> searchResult = new List<string[]>();
            foreach (Payment p in payments)
            {
                string[] item = new string[3];
                item[0] = p.Date.ToShortDateString();
                item[1] = p.Date.ToLongTimeString();
                item[2] = Math.Round(p.Sum, 2).ToString() + " " + Constants.Currency;
                _totalSum += Math.Round(p.Sum, 2); 
                searchResult.Add(item);
            }
            return searchResult;
        }
    }
}
