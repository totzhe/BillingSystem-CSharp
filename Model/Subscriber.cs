using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //private double _balance;

        public double Balance
        {
            get { return GetBalanceByDate(DateTime.Now); }
            set { /*_balance = value;*/ }
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

        private Subscriber(long id, string name, string patronymic, string surname, string email, /*double balance,*/ string login, string passwordHash)
        {
            _id = id;
            _name = name;
            _patronymic = patronymic;
            _surname = surname;
            _email = email;
            //_balance = balance;
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

                string query = "SELECT * FROM subscriber s WHERE LOWER(name) LIKE LOWER (CONCAT('%',@name,'%')) AND LOWER(patronymic) LIKE LOWER (CONCAT('%',@patr,'%')) AND LOWER(surname) LIKE LOWER (CONCAT('%',@surname,'%'))";
                if (phoneNumber != string.Empty)
                    query += "AND number in (SELECT subscriber_id FROM phone_number WHERE number LIKE CONCAT('%',@phone,'%')";
                if (debt > 0)
                {
                    query += " AND (SELECT (SELECT IFNULL(SUM(sum), 0) FROM payment WHERE subscriber_id = s.id) - (SELECT IFNULL(SUM(sum), 0) FROM charge WHERE phone_id IN (SELECT id FROM phone_number WHERE subscriber_id = s.id)) as b FROM dual) < @balance";
                }
                query += " ORDER BY surname, name, patronymic, balance";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@patr", patronymic);
                if (phoneNumber != string.Empty) 
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                if (debt > 0)
                {
                    cmd.Parameters.AddWithValue("@balance", -debt);
                }
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Subscriber(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "patronymic"), r.GetString("surname"), DatabaseUtils.GetStringOrNull(r, "email"), DatabaseUtils.GetStringOrNull(r, "login"), DatabaseUtils.GetStringOrNull(r, "password_hash")));
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
                    result = new Subscriber(id, Constants.No, Constants.No, Constants.No, Constants.No, Constants.No, Constants.DefaultPasswordHash);
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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subscriber WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", subscriberID);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Subscriber(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "patronymic"), r.GetString("surname"), DatabaseUtils.GetStringOrNull(r, "email"), DatabaseUtils.GetStringOrNull(r, "login"), DatabaseUtils.GetStringOrNull(r, "password_hash"));
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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM phone_number WHERE subscriber_id = @id ORDER BY number", connection);
                cmd.Parameters.AddWithValue("@id", ID);
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
                string queryString = "INSERT INTO subscriber (id, name, patronymic, surname, email, login) VALUES (@id, @name, @patr, @surname, @email, @login)";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@patr", Patronymic);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@login", Login);
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
                string queryString = "UPDATE subscriber SET name = @name, patronymic = @patr, surname = @surname, email = @email, login = @login WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@patr", Patronymic);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@login", Login);
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
                string queryString = "DELETE FROM subscriber WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", ID);
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
                string queryString = "UPDATE subscriber SET password_hash = @hash WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@hash", Constants.DefaultPasswordHash);
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
        /// Возвращает платежи абонента за указанный период
        /// </summary>
        /// <param name="from">Начальная дата указанног периода</param>
        /// <param name="to">Конечная дата указанного периода</param>
        /// <returns>Список платежей</returns>
        public List<Payment> SelectPayments(DateTime from, DateTime to)
        {
            List<Payment> searchResult = new List<Payment>();
            try
            {
                connection.Open();
                string query = @"SELECT id, subscriber_id, sum, date FROM payment WHERE subscriber_id = @subscriber_id
                    AND date <= @to AND date >= @from ORDER BY date";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@subscriber_id", _id);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    searchResult.Add(new Payment(r.GetInt64("id"), r.GetInt64("subscriber_id"),
                        r.GetDouble("sum"), r.GetDateTime("date")));
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
            return searchResult;
        }

        public double GetBalanceByDate(DateTime date)
        {
            double balance = 0;
            try
            {
                connection.Open();
                string query = @"SELECT (SELECT IFNULL(SUM(sum), 0) FROM payment WHERE date <= @date AND subscriber_id = @id) - (SELECT IFNULL(SUM(sum), 0) FROM charge WHERE date <= @date AND phone_id IN (SELECT id FROM phone_number WHERE subscriber_id = @id)) as b FROM dual";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@date", date);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    balance = r.GetDouble("b");
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
            return balance;
        }

        public void DepositMoney(double sum)
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO payment (subscriber_id, sum, date) VALUES (@id, @sum, @date)";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@sum", sum);
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

        public string GetFullName()
        {
            return Surname + " " + Name + " " + Patronymic;
        }
    }
}
