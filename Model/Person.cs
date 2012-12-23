using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс пользователя системы.
    /// </summary>
    public abstract class Person
    {        
        protected long _id;

        /// <summary>
        /// Возвращает идентификатор пользователя.
        /// </summary>
        public long ID
        {
            get { return _id; }
        }

        protected string _name;

        /// <summary>
        /// Возвращает или задает имя пользователя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected string _patronymic;

        /// <summary>
        /// Возвращает или задает отчество пользователя.
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        protected string _surname;

        /// <summary>
        /// Возвращает или задает фамилию пользователя.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        protected string _login;

        /// <summary>
        /// Возвращает или задает логин пользователя.
        /// </summary>
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        protected string _passwordHash;

        /// <summary>
        /// Устанавливает значение хеша у пароля по умолчанию. 
        /// </summary>
        public virtual void ResetPassword()
        {
            _passwordHash = Constants.DefaultPasswordHash;
        }
    }
}
