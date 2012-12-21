using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера выбора тарифа.
    /// </summary>
    public interface ISelectTariffController
    {
        /// <summary>
        /// Возвращает название текущего тарифного плана.
        /// </summary>
        /// <returns>Текущее название тарифного плана</returns>
        string GetCurrentTariffName();

        /// <summary>
        /// Возвращает активные тарифы.
        /// </summary>
        /// <returns></returns>
        string[] GetActiveTariffs();

        /// <summary>
        /// Возвращает номер телефона.
        /// </summary>
        /// <returns>Номер телефона</returns>
        string GetPhoneNumber();

        /// <summary>
        /// Возвращает описание тарифного плана по его названию.
        /// </summary>
        /// <param name="tariffName">Название тарифа </param>
        /// <returns>Описание тарифа</returns>
        string GetTariffDescription(string tariffName);

        /// <summary>
        /// Принимает изменения.
        /// </summary>
        /// <param name="tariffName">Название тарифа</param>
        void Confirm(string tariffName);

        /// <summary>
        /// Отмена действий.
        /// </summary>
        void Cancel();
    }
}
