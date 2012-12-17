using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Exceptions
{
    /// <summary>
    /// Класс исключения: не найден объкт модели. Наследует класс System.Exception.
    /// </summary>
    public class ModelObjectNotFoundException : Exception
    {
        /// <summary>
        /// Выполняет инициализацию нового экземпляра класса System.Exception, используя указанное сообщение об ошибке.
        /// </summary>
        /// <param name="message">Сообщение</param>
        public ModelObjectNotFoundException(string message) : base(message) { }
    }
}
