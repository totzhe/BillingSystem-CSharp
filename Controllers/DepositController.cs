using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;
using BillingSystem.Controllers.IControllers;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера пополнения счета для абонента. Реализует интерфейс BillingSystem.Controllers.IControllers.IDepositController.
    /// </summary>
    public class DepositController: IDepositController
    {
        private Subscriber _subscriber;
        
        /// <summary>
        /// Создает экземпляр класса DepositController.
        /// </summary>
        /// <param name="id">Идентификатор абонента</param>
        public DepositController(long id)
        {
            _subscriber = Subscriber.SelectSubscriberByID(id);
        }

        /// <summary>
        /// Возвращает ФИО абонента.
        /// </summary>
        /// <returns>ФИО</returns>
        public string GetFullName()
        {
            return _subscriber.GetFullName();
        }

        /// <summary>
        /// Возвращает баланс абонента.
        /// </summary>
        /// <returns>Баланс</returns>
        public string GetBalance()
        {
            return Math.Round(_subscriber.Balance, 2).ToString() + " " + Constants.Currency;
        }

        /// <summary>
        /// Подтверждает изменения.
        /// </summary>
        /// <param name="sum">Сумма</param>
        public void Confirm(string sum)
        {
            try
            {
                double d = Double.Parse(sum);
                _subscriber.DepositMoney(d);
            }
            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show("Неверный формат суммы!");
            }
        }

        /// <summary>
        /// Отмена действий
        /// </summary>
        public void Cancel()
        {
        }
    }
}
