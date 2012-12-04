using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Other;
using MySql.Data.MySqlClient;

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

        private static MySqlConnection _connection;

        private static MySqlConnection connection
        {
            get
            {
                if (_connection == null)
                    _connection = ConnectionManager.GetConnection();
                return _connection;
            }
        }

        /*private List<PhoneNumber> _phoneNumbers = null;

        private List<PhoneNumber> phoneNumbers
        {
            get
            {
                if (_phoneNumbers == null)
                    _phoneNumbers = GetPhoneNumbers();
                return _phoneNumbers;
            }
        }*/

        private Subscriber(long id, string name, string patronymic, string surname, string email, double balance, string login, string passwordHash)
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

                string query = "SELECT * FROM subscriber WHERE LOWER(name) LIKE LOWER ('%" + name + "%') AND LOWER(patronymic) LIKE LOWER ('%" + patronymic + "%') AND LOWER(surname) LIKE LOWER ('%" + surname + "%')";
                if (phoneNumber != string.Empty)
                    query += "AND number in (SELECT subscriber_id FROM phone_number WHERE number LIKE '%" + phoneNumber + "%')";
                if (debt > 0)
                {
                    query += " AND balance < -" + debt.ToString();
                }
                query += " ORDER BY surname, name, patronymic, balance";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Subscriber(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "patronymic"), r.GetString("surname"), DatabaseUtils.GetStringOrNull(r, "email"), r.GetDouble("balance"), DatabaseUtils.GetStringOrNull(r, "login"), DatabaseUtils.GetStringOrNull(r, "password_hash")));
                }
                r.Close();
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
        /// Создает нового абонента.
        /// </summary>
        /// <returns>Абонент</returns>
        public static Subscriber GetNewSubscriber()
        {
            Subscriber result = null;
            long id;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM subscriber_id", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    id = r.GetInt64("MAX(id)");
                    r.Close();
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE subscriber_id SET id = @id", connection);
                    cmd2.Parameters.AddWithValue("@id", id+1);
                    cmd2.ExecuteNonQuery();
                    result = new Subscriber(id, Constants.No, Constants.No, Constants.No, Constants.No, 0, Constants.No, Constants.DefaultPasswordHash);
                }
                r.Close();
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
                    result = new Subscriber(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "patronymic"), r.GetString("surname"), DatabaseUtils.GetStringOrNull(r, "email"), r.GetDouble("balance"), DatabaseUtils.GetStringOrNull(r, "login"), DatabaseUtils.GetStringOrNull(r, "password_hash"));
                }
                r.Close();
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
        /// <returns>Номера</returns>
        public List<PhoneNumber> GetPhoneNumbers()
        {
            List<PhoneNumber> result = new List<PhoneNumber>();

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM phone_number WHERE subscriber_id = " + ID.ToString() + " ORDER BY number", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new PhoneNumber(r.GetInt64("id"), r.GetInt64("subscriber_id"), r.GetString("number"), r.GetInt64("tariff_id")));
                }
                r.Close();
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
        /// Добавляет запись абонента в БД.
        /// </summary>
        public void Add()
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO subscriber (id, name, patronymic, surname, email, login) VALUES (" + ID.ToString() + ", '" + Name + "', '" + Patronymic + "', '" + Surname + "', '" + Email + "', '" + Login + "')";
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
        /// Обновляет запись абонента в БД.
        /// </summary>
        public void Update()
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE subscriber SET name = '" + Name + "', patronymic = '" + Patronymic + "', surname = '" + Surname + "', email = '" + Email + "', login = '" + Login + "' WHERE id = " + ID.ToString();
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
        /// Удаляет запись абонента в БД.
        /// </summary>
        public void Delete()
        {
            try
            {
                connection.Open();
                string queryString = "DELETE FROM subscriber WHERE id = " + ID.ToString();
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
        public override void ResetPassword()
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE subscriber SET password_hash = '" + Constants.DefaultPasswordHash + "' WHERE id = " + ID.ToString();
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

        public void DepositMoney(double sum)
        {
        }
    }
}
