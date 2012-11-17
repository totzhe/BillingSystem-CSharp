using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BillingSystem.Model;

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
                    throw new Exceptions.NoConnectionException("Database connection doesn't initialized.");
            }
        }

        public static void Connect(string ConnectionString)
        {
            ConnectionManager.Init(ConnectionString);
            _connection = ConnectionManager.GetConnection();
        }

        public static string GetStringOrNull(this MySqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? null : reader.GetString(columnName);
        }

        /// <summary>
        /// Получает из БД абонентов, удовлетворяющих указанным параметрам.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="phoneNumber">Телефон</param>
        /// <param name="debt">Размер задолженности</param>
        /// <returns>Список абонентов</returns>
        public static List<Subscriber> SelectSubscribers(string name, string patronymic, string surname, string phoneNumber, double debt)
        {
            List<Subscriber> result = new List<Subscriber>();

            try
            {
                connection.Open();

                /*string stm = "SELECT VERSION()";
                MySqlCommand cmd = new MySqlCommand(stm, connection);
                string version = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine("MySQL version : {0}", version);*/
                string query = "SELECT * FROM subscriber WHERE LOWER(name) LIKE LOWER ('%" + name + "%') AND LOWER(patronymic) LIKE LOWER ('%" + patronymic + "%') AND LOWER(surname) LIKE LOWER ('%" + surname + "%') AND id in (SELECT subscriber_id FROM phone_number WHERE number LIKE '%" + phoneNumber + "%')";
                if (debt > 0)
                {
                    query+=" AND balance < -" + debt.ToString();
                }
                query += " ORDER BY surname, name, patronymic, balance";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Subscriber(r.GetInt64("id"), r.GetString("name"), GetStringOrNull(r, "patronymic"), r.GetString("surname"), GetStringOrNull(r, "email"), r.GetDouble("balance"), GetStringOrNull(r, "login"), GetStringOrNull(r, "password_hash")));
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Получает из БД все номера указанного абонента.
        /// </summary>
        /// <param name="subscriber">Абонент</param>
        /// <returns>Номера</returns>
        public static List<PhoneNumber> SelectPhoneNumbers(Subscriber subscriber)
        {
            List<PhoneNumber> result = new List<PhoneNumber>();

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM phone_number WHERE subscriber_id = " + subscriber.ID.ToString(), connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new PhoneNumber(r.GetInt64("id"), r.GetInt64("subscriber_id"), r.GetString("number"), r.GetInt64("tariff_id")));
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Получает абонента из БД по его id.
        /// </summary>
        /// <param name="subscriberID">id абонента</param>
        /// <returns>Абонент</returns>
        public static Subscriber SelectSubscriberByID(long subscriberID)
        {
            Subscriber result = null;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subscriber WHERE id = " + subscriberID.ToString(), connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Subscriber(r.GetInt64("id"), r.GetString("name"), GetStringOrNull(r, "patronymic"), r.GetString("surname"), GetStringOrNull(r, "email"), r.GetDouble("balance"), GetStringOrNull(r, "login"), GetStringOrNull(r, "password_hash"));                
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Обновляет запись абонента в БД.
        /// </summary>
        /// <param name="subscriber">Абонент</param>
        public static void UpdateSubscriber(Subscriber subscriber)
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE subscriber SET name = '" + subscriber.Name + "', patronymic = '" + subscriber.Patronymic + "', surname = '" + subscriber.Surname + "', email = '" + subscriber.Email + "', login = '" + subscriber.Login + "' WHERE id = " + subscriber.ID.ToString();
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Сбрасывает пароль абонента.
        /// </summary>
        /// <param name="subscriber">Абонент</param>
        public static void ResetSubscriberPassword(Subscriber subscriber)
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE subscriber SET password_hash = '" + Constants.DefaultPasswordHash + "' WHERE id = " + subscriber.ID.ToString();
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Получает телефонный номер из БД по его id.
        /// </summary>
        /// <param name="phoneNumberID">id номера</param>
        /// <returns>Номер</returns>
        public static PhoneNumber SelectPhoneNumberByID(long phoneNumberID)
        {
            PhoneNumber result = null;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM phone_number WHERE id = " + phoneNumberID.ToString(), connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new PhoneNumber(r.GetInt64("id"), r.GetInt64("subscriber_id"), r.GetString("number"), r.GetInt64("tariff_id"));
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Получает тариф из БД по его id.
        /// </summary>
        /// <param name="tariffID">id тарифа</param>
        /// <returns>Тариф</returns>
        public static Tariff SelectTariffByID(long tariffID)
        {
            Tariff result = null;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tariff WHERE id = " + tariffID.ToString(), connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Tariff(r.GetInt64("id"), r.GetString("name"), GetStringOrNull(r, "description"), r.GetBoolean("active"));
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Получает из БД активные тарифы с указанным именем.
        /// </summary>
        /// <param name="tariffName">Имя или часть имени тарифа</param>
        /// <returns>Список тарифов</returns>
        public static List<Tariff> SelectActiveTariffs(string tariffName)
        {
            List<Tariff> result = new List<Tariff>();

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tariff WHERE active > 0 AND LOWER(name) LIKE LOWER('%" + tariffName + "%')", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Tariff(r.GetInt64("id"), r.GetString("name"), GetStringOrNull(r, "description"), r.GetBoolean("active")));
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        /// <summary>
        /// Обновляет телефон в БД.
        /// </summary>
        /// <param name="phoneNumber">Телефон</param>
        public static void UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE subscriber SET number = '" + phoneNumber.Number + "', subscriber_id = " + phoneNumber.SubscriberID.ToString() + ", tariff_id = " + phoneNumber.TariffID.ToString() + " WHERE id = " + phoneNumber.ID.ToString();
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        //TODO: Сделать всякие запросы к БД по необходимости, стараться передавать в методы и возвращать не просто данные (строки, числа и т.п.), а объекты модели
    }
}
