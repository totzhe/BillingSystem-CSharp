using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers.IControllers
{
    /// <summary>
    /// Интерфейс контроллера пополнения счета.
    /// </summary>
    public interface IDepositController
    {
        /// <summary>
        /// Возвращает ФИО абонента.
        /// </summary>
        /// <returns>ФИО</returns>
        string GetFullName();

        /// <summary>
        /// Возвращает баланс абонента.
        /// </summary>
        /// <returns>Баланс</returns>
        string GetBalance();

        /// <summary>
        /// Подтверждает изменения.
        /// </summary>
        /// <param name="sum">Сумма</param>
        void Confirm(string sum);

        /// <summary>
        /// Отменить действия.
        /// </summary>
        void Cancel();
    }
}
