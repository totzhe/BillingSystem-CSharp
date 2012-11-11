using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BillingSystem.DataModel;

namespace BillingSystem
{
    public class DatabaseUtils
    {
        private static MySqlConnection _connection;

        private static MySqlConnection connection
        {
            get
            {
                if (_connection != null)
                    return _connection;
                else
                    throw new Exceptions.NoConnectionException("Database connection not open.");
            }
        }
        
        private billingEntities1 context;

        public DatabaseUtils()
        {
            context = new billingEntities1();
        }

        public static void Connect(string ConnectionString)
        {
            ConnectionManager.Init(ConnectionString);
            _connection = ConnectionManager.GetConnection();
        }

        public List<subscriber> FindCustomerList(string name)
        {
            var q = from c in context.subscriber
                    //where c.name.StartsWith(name)
                    select c;
            return q.ToList();
        }


        //TODO: Сделать всякие запросы к БД по необходимости, стараться передавать в методы и возвращать не просто данные (строки, числа и т.п.), а объекты модели
    }
}
