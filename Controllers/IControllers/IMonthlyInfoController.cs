using System;
using System.Collections.Generic;
namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера информации за месяц.
    /// </summary>
    public interface IMonthlyInfoController
    {
        /// <summary>
        /// Возвращает списания за месяц.
        /// </summary>
        /// <param name="date">Месяц</param>
        /// <returns>Списания</returns>
        List<Dictionary<string, string>> GetCharges(DateTime date);

        /// <summary>
        /// Возвращает платежи за месяц.
        /// </summary>
        /// <param name="date">Месяц</param>
        /// <returns>Платежи</returns>
        List<Dictionary<string, string>> GetPayments(DateTime date);

        /// <summary>
        /// Возвращает сумму списаний.
        /// </summary>
        /// <returns>Сумма</returns>
        string GetChargesSum();

        /// <summary>
        /// Возвращает сумму платежей.
        /// </summary>
        /// <returns>Сумма</returns>
        string GetPaymentsSum();

        /// <summary>
        /// Возвращает общий долг всех абонентов за месяц.
        /// </summary>
        /// <returns>Сумма</returns>
        string GetDebt();
    }
}
