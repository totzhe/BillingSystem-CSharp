using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem
{
    /// <summary>
    /// Класс констант.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Рубли.
        /// </summary>
        public const string Currency = "руб.";

        /// <summary>
        /// Нет.
        /// </summary>
        public const string No = "Нет";
        
        /// <summary>
        /// Неизвестно.
        /// </summary>
        public const string NoInfo = "Неизвестно";

        /// <summary>
        /// Хеш пароля по умолчанию.
        /// </summary>
        public const string DefaultPasswordHash = "111";

        /// <summary>
        /// Строка подключения.
        /// </summary>
        public const string ConnectionString = @"server=vragov.com;userid=billing;password=billing;database=billing;charset=utf8";
        //public const string ConnectionString = @"server=localhost;userid=root;password=;database=billing;charset=utf8";

        /// <summary>
        /// Входящий.
        /// </summary>
        public const string Incoming = "Входящий";
        
        /// <summary>
        /// Исходящий.
        /// </summary>
        public const string Outgoing = "Исходящий";
        
        /// <summary>
        /// Время начала.
        /// </summary>
        public const string StartTime = "Время начала";
        
        /// <summary>
        /// Время завершения.
        /// </summary>
        public const string EndTime = "Время завершения";

        /// <summary>
        /// Смена тарифа.
        /// </summary>
        public const string TariffChanging = "Смена тарифа";
        
        /// <summary>
        /// Оплата звонков.
        /// </summary>
        public const string ChargeCalls = "Оплата звонков";
    }
}
