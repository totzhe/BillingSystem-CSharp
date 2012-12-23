using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера детализированной информации о смене тарифа. Наследует класс BillingSystem.Controllers.Controllers.DetailedInfController.
    /// </summary>
    class TariffsDetailedInfController : DetailedInfController
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
        /// Создает экземпляр класса TariffsDetailedInfController.
        /// </summary>
        /// <param name="subscriberID">ID абонента</param>
        public TariffsDetailedInfController(long subscriberID)
            : base(subscriberID)
        {
        }

        /// <summary>
        /// Возвращает детализированную информацию о смене тарифов по указанным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="from">Начало периода использования тарифа</param>
        /// <param name="to">Конец периода использования тарифа</param>
        /// <returns>Информация об использовании тарифов</returns>
        public override List<string[]> Search(string phoneNumber, DateTime from, DateTime to)
        {
            PhoneNumber pn = PhoneNumber.SelectPhoneNumberByNumber(phoneNumber);
            List<TariffHistory> tariffHistory = pn.SelectTariffHistory(from, to);
            List<Charge> charges = pn.SelectCharges(from, to);
            List<string[]> searchResult = new List<string[]>();

            foreach (Charge ch in charges)
            {
                if (ch.GetService().Name == "Смена тарифа")
                {
                    _totalSum += Math.Round(ch.Sum, 2);
                }
            }

            foreach (TariffHistory th in tariffHistory)
            {
                string[] items = new string[6];
                items[0] = th.StartDate.ToShortDateString();
                items[1] = th.StartDate.ToLongTimeString();
                items[2] = th.TariffName;
                if (th.EndDate != null)
                {
                    items[3] = th.EndDate.Value.ToShortDateString();
                    items[4] = th.EndDate.Value.ToLongTimeString();
                }
                else
                {
                    items[3] = Constants.NoInfo;
                    items[4] = Constants.NoInfo;
                }
                items[5] = Service.SelectServiceByName("Смена тарифа").Cost.ToString() + " " + Constants.Currency;
                searchResult.Add(items);
            }
            return searchResult;
        }
    }
}