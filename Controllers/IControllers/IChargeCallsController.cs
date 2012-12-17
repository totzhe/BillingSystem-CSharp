using System;
using System.Collections.Generic;

namespace BillingSystem.Controllers.IControllers
{
    /// <summary>
    /// Интерфейс контроллера списаний за звонки.
    /// </summary>
    public interface IChargeCallsController
    {
        /// <summary>
        /// Вычисляет сумму списаний за месяц.
        /// </summary>
        /// <param name="date">Месяц</param>
        void CalculateCharges(DateTime date);
        
        /// <summary>
        /// Подтверждает списание.
        /// </summary>
        void ConfirmCharges();
        
        /// <summary>
        /// Получает списания.
        /// </summary>
        /// <returns>Списания</returns>
        List<Dictionary<string, string>> GetCharges();
    }
}
