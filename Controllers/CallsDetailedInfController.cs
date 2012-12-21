using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера детализированной информации о звонках. Наследует класс BillingSystem.Controllers.DetailedInfController.
    /// </summary>
    class CallsDetailedInfController : DetailedInfController
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
        /// Создает экземпляр класса CallsDetailedInfController.
        /// </summary>
        /// <param name="subscriberID">Идентификатор абонента</param>
        public CallsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }
        
        /// <summary>
        /// Возвращает детализированную информацию о звонках, удовлетворяющую заданным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="from">Начало периода</param>
        /// <param name="to">Конец периода </param>
        /// <returns>Детализированная информация о звонках</returns>
        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<Call> calls = pn.SelectCalls(from, to);
            List<string[]> searchResult = new List<string[]>();

            foreach (Call c in calls)
            {
                string[] item = new string[6];
                item[0] = c.StartTime.ToShortDateString();
                item[1] = c.StartTime.ToLongTimeString();
                if (c.CalledNumber == pn.Number)
                {
                    item[2] = c.CallingNumber;
                    item[3] = Constants.Incoming;
                    item[5] = Constants.No;
                }
                else
                {
                    item[2] = c.CalledNumber;
                    Tariff tariff = pn.SelectTariffByDate(c.StartTime);
                    item[3] = Constants.Outgoing;
                    item[5] = Math.Round(BillingOperations.CalculateCallCost(c, tariff), 2).ToString() + " " + Constants.Currency;
                    _totalSum += Math.Round(BillingOperations.CalculateCallCost(c, tariff), 2);
                }
                item[4] = c.Duration.ToString();
                searchResult.Add(item);
            }
            return searchResult;
        }
    }
}
