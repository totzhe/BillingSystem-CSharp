using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера поиска абонентов.
    /// </summary>
    public interface ISearchController
    {
        /// <summary>
        /// Возвращает список абонентов по заданным параметрам:
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="phoneNumber">Номер</param>
        /// <param name="debt">Размер задолжености</param>
        /// <returns>Список информации об абонентах</returns>
        List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, string debt);

        /// <summary>
        /// Вызывает форму добавления абонента.
        /// </summary>
        void AddSubscriber();

        /// <summary>
        /// Вызывает форму редактирования абонента.
        /// </summary>
        /// <param name="id">Идентификатор абонента</param>
        void EditSubscriber(long id);

        /// <summary>
        /// Вызывает форму детализации абонента.
        /// </summary>
        /// <param name="id">Идентификатор абонента</param>
        void ShowInfo(long id);

        /// <summary>
        /// Вызывает форму пополнения счета для абонента.
        /// </summary>
        /// <param name="id">Идентификатор абонента</param>
        void Deposit(long id);

        /// <summary>
        /// Вызывает форму импорта звонков.
        /// </summary>
        void ShowCallsImport();

        /// <summary>
        /// Вызывает форму изменения тарифа.
        /// </summary>
        void ShowEditTariff();

        /// <summary>
        /// Вызывает форму добавления тарифа.
        /// </summary>
        void ShowAddTariff();

        /// <summary>
        /// Вызывает форму импорта тарифа.
        /// </summary>
        void ShowImportTariff();

        /// <summary>
        /// Вызывает форму расчета и списания стоимости звонков.
        /// </summary>
        void ChargeCalls();

        /// <summary>
        /// Вызывает форму показа статистики за месяц.
        /// </summary>
        void ShowMonthlyInfo();
    }
}
