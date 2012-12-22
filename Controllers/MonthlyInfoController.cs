using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;
using BillingSystem.Controllers.IControllers;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера информации за месяц. Реализует интерфейс BillingSystem.Controllers.IControllers.IMonthlyInfoController.
    /// </summary>
    public class MonthlyInfoController : IMonthlyInfoController
    {
        private double payments_sum = 0;

        private double charges_sum = 0;

        /// <summary>
        /// Возвращает все списания за месяц.
        /// </summary>
        /// <param name="date">Месяц</param>
        /// <returns>Списания</returns>
        public List<Dictionary<string, string>> GetCharges(DateTime date)
        {
            DateTime from = new DateTime(date.Year, date.Month, 1, 0, 0, 0, 0);
            DateTime to = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month), 23, 59, 59, 59);
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            List<PhoneNumber> numbers = PhoneNumber.SelectAllPhoneNumbers();
            charges_sum = 0;
            foreach (PhoneNumber number in numbers)
            {
                double sum = 0;
                foreach (Charge charge in number.SelectCharges(from, to))
                {
                    sum += charge.Sum;
                }
                if (sum > 0)
                {
                    Dictionary<string, string> d = new Dictionary<string, string>();
                    d.Add("number", number.Number);
                    d.Add("sum", Math.Round(sum, 2).ToString() + " " + Constants.Currency);
                    result.Add(d);
                    charges_sum += sum;
                }
            }
            return result;
        }

        /// <summary>
        /// Возвращает все платежи абонентов за месяц.
        /// </summary>
        /// <param name="date">Месяц</param>
        /// <returns>Платежи</returns>
        public List<Dictionary<string, string>> GetPayments(DateTime date)
        {
            DateTime from = new DateTime(date.Year, date.Month, 1, 0, 0, 0, 0);
            DateTime to = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month), 23, 59, 59, 59);
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            List<Subscriber> subscribers = Subscriber.SelectSubscribers("", "", "", "", -1);
            payments_sum = 0;
            foreach (Subscriber subs in subscribers)
            {
                double sum = 0;
                foreach (Payment payment in subs.SelectPayments(from, to))
                {
                    sum += payment.Sum;
                }
                if (sum > 0)
                {
                    Dictionary<string, string> d = new Dictionary<string, string>();
                    d.Add("subscriber", subs.GetFullName());
                    d.Add("sum", Math.Round(sum, 2).ToString() + " " + Constants.Currency);
                    result.Add(d);
                    payments_sum += sum;
                }
            }
            return result;
        }

        /// <summary>
        /// Возвращает сумму списаний за месяц.
        /// </summary>
        /// <returns>Сумма</returns>
        public string GetChargesSum()
        {
            return Math.Round(charges_sum, 2) + " " + Constants.Currency;
        }

        /// <summary>
        /// Возвращает сумму платежей за месяц.
        /// </summary>
        /// <returns>Сумма</returns>
        public string GetPaymentsSum()
        {
            return Math.Round(payments_sum, 2) + " " + Constants.Currency;
        }

        /// <summary>
        /// Возвращает общий долг всех абонентов за месяц.
        /// </summary>
        /// <returns>Сумма</returns>
        public string GetDebt()
        {
            return Math.Round(charges_sum - payments_sum , 2) + " " + Constants.Currency;
        }
    }
}
