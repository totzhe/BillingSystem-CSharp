using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера добавления абонента. Наследует класс BillingSystem.Controllers.SubscriberController.
    /// </summary>
    public class AddSubscriberController : SubscriberController
    {
        /// <summary>
        /// Создает экземпляр класса AddSubscriberController.
        /// </summary>
        public AddSubscriberController() : base() { }
        
        /// <summary>
        /// Подтверждает изменения для следующих параметров:
        /// </summary>
        /// <param name="name">Имя абонента</param>
        /// <param name="patronymic">Отчество абонента</param>
        /// <param name="surname">Фамилия абонента</param>
        /// <param name="email">Адрес электронной почты абонента</param>
        /// <param name="login">Логин абонента</param>
        public override void ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name == null ? Constants.NoInfo : name.Trim();
            subscriber.Patronymic = patronymic == null ? null : patronymic.Trim();
            subscriber.Surname = surname == null ? Constants.NoInfo : surname.Trim();
            subscriber.Email = email == null ? null : email.Trim();
            subscriber.Login = login == null ? null : login.Trim();
            subscriber.Add();
            foreach (PhoneNumber n in _phonesToUpdate)
                n.Update();
            foreach (PhoneNumber n in _phonesToAdd)
                n.Add();
            foreach (PhoneNumber n in _phonesToDelete)
                n.Delete();
        }       
        
    }
}