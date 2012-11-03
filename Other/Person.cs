using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Other
{
    public abstract class Person
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _patronymic;

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _passwordHash;

        private string _saltHash;

        public void ResetPassword()
        {

        }
    }
}
