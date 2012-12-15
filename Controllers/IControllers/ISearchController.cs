using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface ISearchController
    {
        /// <summary>
        /// Метод возвращает список пользователей по заданным параметрам.
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="phoneNumber">Номер пользователя</param>
        /// <param name="debt">Размер задолжености</param>
        /// <returns>Возвращает список массива строк</returns>
        List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, string debt);

        /// <summary>
        /// Создает форму добавления пользователя.
        /// </summary>
        void AddSubscriber();

        /// <summary>
        /// Создает форму редактирования пользователя.
        /// </summary>
        /// <param name="number">number пользователя</param>
        void EditSubscriber(long id);

        /// <summary>
        /// Создает форму детализации пользователя.
        /// </summary>
        /// <param name="number">number пользователя</param>
        void ShowInfo(long id);

        /// <summary>
        /// Вызывает форму пополнения баланса
        /// </summary>
        /// <param name="id"></param>
        void Deposit(long id);

        /// <summary>
        /// Создает форму импорта звонков
        /// </summary>
        void ShowCallsImport();

        /// <summary>
        /// Создает форму изменения тарифа
        /// </summary>
        void ShowEditTariff();

        /// <summary>
        /// Создает форму расчета и списания стоимости звонков
        /// </summary>
        void ChargeCalls();

        /// <summary>
        /// Создает форму показа статистики за месяц
        /// </summary>
        void ShowMonthlyInfo();
    }
}
