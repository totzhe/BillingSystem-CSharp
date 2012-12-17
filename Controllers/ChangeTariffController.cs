using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера изменения тарифа. Реализует интерфейс BillingSystem.Controllers.IControllers.ISelectTariffController.
    /// </summary>
    public class ChangeTariffController : ISelectTariffController
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private PhoneNumber _number;

        /// <summary>
        /// Тариф.
        /// </summary>
        private Tariff _tariff;
        
        /// <summary>
        /// Создает экземпляр класса ChangeTariffController.
        /// </summary>
        /// <param name="number">Номер телефона</param>
        public ChangeTariffController(PhoneNumber number)
        {
            _number = number;
            _tariff = _number.GetTariff();
        }

        /// <summary>
        /// Возвращает название текущего тарифного плана или сообщает информацию о его отсутствии.
        /// </summary>
        /// <returns>Название тарифа</returns>
        public string GetCurrentTariffName()
        {
            if (_tariff != null)
                return _tariff.Name;
            else
                return Constants.No;
        }

        /// <summary>
        /// Возвращает список активных тарифов.
        /// </summary>
        /// <returns>Активные тарифы</returns>
        public string[] GetActiveTariffs()
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName("");
            string[] result = new string[tariffs.Count];
            int i = 0;
            foreach (Tariff t in tariffs)
                result[i++] = t.Name;
            return result;
        }

        /// <summary>
        /// Получает номер телефона.
        /// </summary>
        /// <returns>Номер телефона</returns>
        public string GetPhoneNumber()
        {
            return _number.Number;
        }

        /// <summary>
        /// Получает описание тарифного плана.
        /// </summary>
        /// <param name="tariffName">Название тарифного плана</param>
        /// <returns>Описание тарифного плана</returns>
        public string GetTariffDescription(string tariffName)
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName(tariffName);
            if (tariffs.Count > 0)
                return tariffs[0].Description;
            else
                return null;
        }

        /// <summary>
        /// Подтверждает изменения.
        /// </summary>
        /// <param name="tariffName">Имя тарифного плана</param>
        public void Confirm(string tariffName)
        {
            List<Tariff> tariffs = Tariff.SelectActiveTariffsByName(tariffName);
            if (tariffs.Count > 0)
            {
                _number.TariffID = tariffs[0].ID;
                //DatabaseUtils.Update(_number);
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
