using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Exceptions
{
    /// <summary>
    /// Класс исключения: нет соединения. Наследует класс System.Exception.
    /// </summary>
    public class NoConnectionException : Exception
    {
        /// <summary>
        /// Выполняет инициализацию нового экземпляра класса System.Exception, используя указанное сообщение об ошибке.
        /// </summary>
        /// <param name="message">Сообщение</param>
        public NoConnectionException(string message) : base(message) { }
    }
}
