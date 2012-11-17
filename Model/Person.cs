using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public abstract class Person
    {
        protected long _id;

        public long ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected string _patronymic;

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        protected string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        protected string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        protected string _passwordHash;

        //private string _passwordSalt;

        public void ResetPassword()
        {
            _passwordHash = Constants.DefaultPasswordHash;
        }
    }
}
