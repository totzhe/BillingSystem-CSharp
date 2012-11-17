using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Other;

namespace BillingSystem.Model
{
    public class Subscriber : Person
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Subscriber(long id, string name, string patronymic, string surname, string email, double balance, string login, string passwordHash)
        {
            _id = id;
            _name = name;
            _patronymic = patronymic;
            _surname = surname;
            _email = email;
            _balance = balance;
            _login = login;
            _passwordHash = passwordHash;
        }

        /*public void WriteOffMoney(double sum)
        {
        }*/

        public void DepositMoney(double sum)
        {
        }

        public void ChangeEmail(string email)
        {
        }
    }
}
