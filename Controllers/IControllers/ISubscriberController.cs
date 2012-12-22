using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера абонента.
    /// </summary>
    public interface ISubscriberController
    {
        /// <summary>
        /// Возвращает имя абонента.
        /// </summary>
        /// <returns>Имя</returns>
        string getName();

        /// <summary>
        /// Возвращает фамилию абонента.
        /// </summary>
        /// <returns>Фамилия</returns>
        string getSurname();

        /// <summary>
        /// Возвращает отчество абонента.
        /// </summary>
        /// <returns>Отчество</returns>
        string getPatronymic();

        /// <summary>
        /// Возвращает адрес электронной почты абонента.
        /// </summary>
        /// <returns>Адрес электронной почты</returns>
        string getEmail();

        /// <summary>
        /// Возвращает логин абонента.
        /// </summary>
        /// <returns>Логин</returns>
        string getLogin();

        /// <summary>
        /// Возвращает список имеющихся у абонента телефонных  номеров и их тарифы.
        /// </summary>
        /// <returns>Телефонные номера и их тарифы</returns>
        List<string[]> getPhoneNumbers();

        /// <summary>
        /// Добавляет абоненту телефонный номер.
        /// </summary>
        void AddPhoneNumber();
        
        /// <summary>
        /// Редактирует телефонный номер абонента.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        void EditPhoneNumber(string phoneNumber);

        /// <summary>
        /// Удаляет телефонный номер у абонента.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        void DeletePhoneNumber(string phoneNumber);

        /// <summary>
        /// Сбрасывает пароль абонента.
        /// </summary>
        void ResetPassword();

        /// <summary>
        /// Подтверждает изменения.
        /// </summary>
        /// <param name="name">Имя абонента</param>
        /// <param name="patronymic">Отчество абонента</param>
        /// <param name="surname">Фамилия абонента</param>
        /// <param name="email">Адрес электронной почты абонента</param>
        /// <param name="login">Логин абонента</param>
        void ConfirmChanges(string name, string patronymic, string surname, string email, string login);

        /// <summary>
        /// Отмена действий.
        /// </summary>
        void Cancel();
    }
}
