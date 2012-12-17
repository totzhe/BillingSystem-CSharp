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
        /// <summary>
        /// Создает экземпляр класса ChargesDetailedInfController.
        /// </summary>
        /// <param name="subscriberID">ID абонента</param>
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
                result.Add(item);
            }
            return result;
        }
    }
}
