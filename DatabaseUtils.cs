using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem
{
    public static class DatabaseUtils
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

        public static void Connect(string ConnectionString)
        {
            ConnectionManager.Init(ConnectionString);
            _connection = ConnectionManager.GetConnection();
        }


        //TODO: Сделать всякие запросы к БД по необходимости, стараться передавать в методы и возвращать не просто данные (строки, числа и т.п.), а объекты модели
    }
}
