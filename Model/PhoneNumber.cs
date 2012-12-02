using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class PhoneNumber
    {
        private long _id;

        public long ID
        {
            get { return _id; }
        }

        private long _subscriberID;

        public long SubscriberID
        {
            get { return _subscriberID; }
            set { _subscriberID = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { /*_number = value;*/ }
        }

        private long _tariffID;

        public long TariffID
        {
            get { return _tariffID; }
            set { _tariffID = value; }
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

        public PhoneNumber(long id, long subscriberID, string number, long tariffID)
        {
            _id = id;
            _subscriberID = subscriberID;
            _number = number;
            _tariffID = tariffID;
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
        /// Получает телефонный номер из БД по значению номера.
        /// </summary>
        /// <param name="phoneNumber">Значение номера</param>
        /// <returns></returns>
        public static PhoneNumber SelectPhoneNumberByNumber(string phoneNumber)
        {
            PhoneNumber result = null;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM phone_number WHERE number = '" + phoneNumber + "'", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new PhoneNumber(r.GetInt64("id"), r.GetInt64("subscriber_id"), r.GetString("number"), r.GetInt64("tariff_id"));
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
        /// Обновляет телефон в БД.
        /// </summary>
        public void Update()
        {
            try
            {
                connection.Open();
                string queryString = "UPDATE phone_number SET number = '" + Number + "', subscriber_id = " + SubscriberID.ToString() + ", tariff_id = " + TariffID.ToString() + " WHERE id = " + ID.ToString() + " OR number = '" + Number + "'";
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
        /// Добавляет телефон в БД.
        /// </summary>
        public void Add()
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO phone_number (number,  subscriber_id, tariff_id) VALUES  ('" + Number + "', " + SubscriberID.ToString() + ", " + TariffID.ToString() + ")";
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
        /// Удаляет телефон из БД.
        /// </summary>
        public void Delete()
        {
            try
            {
                connection.Open();
                string queryString = "DELETE FROM phone_number WHERE id = " + ID.ToString() + " OR number = '" + Number + "'";
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
        /// Возвращает новый не занятый номер телефона.
        /// </summary>
        /// <returns>Телефон</returns>
        public static PhoneNumber GetNewNumber()
        {
            PhoneNumber result = null;
            long number;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT MAX(number) FROM free_phone_number", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    number = r.GetInt64("MAX(number)");
                    r.Close();
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE free_phone_number SET number = @number", connection);
                    cmd2.Parameters.AddWithValue("@number", number + 1);
                    cmd2.ExecuteNonQuery();
                    result = new PhoneNumber(-1, -1, "+" + number.ToString(), -1);
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
        /// Возвращает тариф для этого телефона в указанный момент времени
        /// </summary>
        /// <param name="date">Дата и время</param>
        /// <returns>Тариф</returns>
        public Tariff SelectTariffByDate(DateTime date)
        {
            Tariff result = null;
            try
            {
                connection.Open();

                string query = "SELECT * FROM tariff WHERE id = (SELECT tariff_id FROM tariff_history WHERE phone_id = @phone_id AND start_date <= @date AND (end_date > @date OR end_date IS NULL))";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@phone_id", ID);
                cmd.Parameters.AddWithValue("@date", date);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result = new Tariff(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "description"), r.GetBoolean("active"));
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
        /// Возвращает все звонки для данного номера за указанный период
        /// </summary>
        /// <param name="from">Начало периода</param>
        /// <param name="to">Конец периода</param>
        /// <returns>Звонки</returns>
        public List<Call> SelectCalls(DateTime from, DateTime to)
        {
            List<Call> result = new List<Call>();
            try
            {
                connection.Open();

                string query = "SELECT * FROM calls WHERE (calling_number = '" + Number + "' OR called_number = '" + Number + "')"
                    + " AND DATE(start_time) >= DATE(@from) AND DATE(start_time) <= DATE(@to) AND end_time IS NOT NULL ORDER BY start_time, end_time, called_number, calling_number";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                //System.Windows.Forms.MessageBox.Show(cmd.CommandText);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Call(r.GetInt64("id"), r.GetString("calling_number"),
                        r.GetString("called_number"), r.GetDateTime("start_time"), r.GetDateTime("end_time")));
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
        /// Возвращает текущий тариф
        /// </summary>
        /// <returns>Текущий тариф</returns>
        public Tariff GetTariff()
        {
            return Tariff.SelectTariffByID(TariffID);
        }


        public void WriteOffMoney(Charge charge)
        {            
        }
    }
}
