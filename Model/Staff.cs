using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс обслуживающего персонала. Наследует класс BillingSystem.Model.Person.
    /// </summary>
    public class Staff : Person
    {
        private string _position;

        /// <summary>
        /// Возвращает или задает должность работника.
        /// </summary>
        public string Position
        {
            get { return _position; }
            set { }
        }
    }
}
