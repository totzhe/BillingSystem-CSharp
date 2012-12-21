using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера детализированной информации.
    /// </summary>
    public interface IDetailedInfController
    {
        /// <summary>
        ///Возвращает список телефонных номеров, имеющихся у пользователя.
        /// </summary>
        /// <returns>Номера телефонов</returns>
        List<string> GetPhoneNumbers();

        /// <summary>
        /// Возвращает ФИО абонента.
        /// </summary>
        /// <returns>ФИО</returns>
        string GetSubscriberFullName();

        /// <summary>
        /// Осуществляет поиск информации по заданным параметрам:
        /// </summary>
        /// <param name="phoneNumber">Телефонный номер</param>
        /// <param name="from">Дата начала периода</param>
        /// <param name="to">Дата конца периода</param>
        /// <returns>Список информации</returns>
        List<string[]> Search(string phoneNumber, DateTime from, DateTime to);

        /// <summary>
        /// Возвращает баланс абонента по состоянию на определенную дату.
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Баланс</returns>
        string GetBalanceByDate(DateTime date);

        /// <summary>
        /// Возвращает текущий баланс абонента.
        /// </summary>
        /// <returns>Баланс</returns>
        string GetBalance();
    }
}