using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс списания.
    /// </summary>
    public class Charge
    {
        private long _id;

        /// <summary>
        /// Возвращает или задает идентификатор списания.
        /// </summary>
        public long ID
        {
            get { return _id; }
            set { }
        }

        private long _phoneID;

        /// <summary>
        /// Возвращает или задает идентификатор телефонного номера у списания.
        /// </summary>
        public long PhoneID
        {
            get { return _phoneID; }
            set { }
        }

        private long _serviceID;

        /// <summary>
        /// Возвращает или задает идентификатор услуги, за которую произведено списание.
        /// </summary>
        public long ServiceID
        {
            get { return _serviceID; }
            set { }
        }

        private double _sum;

        /// <summary>
        /// Возвращает или задает сумму списания.
        /// </summary>
        public double Sum
        {
            get { return _sum; }
            set { }
        }

        private DateTime _date;

        /// <summary>
        /// Возвращает или задает дату списания.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { }
        }

        private PhoneNumber _phoneNumber;

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

        /// <summary>
        /// Инициализирует новый экземпляр класса Charge, получая в качесте аргументов следущие параметры:
        /// </summary>
        /// <param name="item">Телефонный номер</param>
        /// <param name="service">Услуга</param>
        /// <param name="sum">Сумма</param>
        /// <param name="date">Дата</param>
        public Charge(PhoneNumber phone, Service service, double sum, DateTime date)
        {
            _date = date;
            _phoneID = phone.ID;
            _serviceID = service.ID;
            _sum = sum + service.Cost;
            _phoneNumber = phone;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Charge, получая в качесте аргументов следущие параметры:
        /// </summary>
        /// <param name="id">ID списания</param>
        /// <param name="phoneID">ID телефонного номера</param>
        /// <param name="serviceID">ID услуги</param>
        /// <param name="sum">Сумма</param>
        /// <param name="date">Дата</param>
        public Charge(long id, long phoneID, long serviceID, double sum, DateTime date)
        {
            _id = id;
            _phoneID = phoneID;
            _serviceID = serviceID;
            _sum = sum;
            _date = date;
        }

        /// <summary>
        /// Получает услугу.
        /// </summary>
        /// <returns>Услуга</returns>
        public Service GetService()
        {
            return Service.SelectServiceByID(_serviceID);
        }

        /// <summary>
        /// Обновляет поле баланса в таблице базы данных.
        /// </summary>
        public void WriteOff()
        {
            try
            {
                connection.Open();
                string queryString = @"UPDATE subscriber SET balance = balance - @sum WHERE id = @id; 
                INSERT INTO charge (phone_id, service_id, sum, date) VALUES (@phone_id, @service_id, @sum, @date)";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@sum", _sum);
                cmd.Parameters.AddWithValue("@id", _phoneNumber.SubscriberID);
                cmd.Parameters.AddWithValue("@phone_id", _phoneID);
                cmd.Parameters.AddWithValue("@service_id", _serviceID);
                cmd.Parameters.AddWithValue("@date", _date);
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
        /// Удаляет запись о списании с заданным идентификатором услуги из таблицы базы данных. 
        /// </summary>
        /// <param name="serviceID">Идентификатор услуги</param>
        /// <param name="from">Дата начала</param>
        /// <param name="to">Дата окончания</param>
        public static void RemoveCharges(long serviceID, DateTime from, DateTime to)
        {            
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM charge WHERE service_id = @service_id AND date >= @from AND date <= @to", connection);
                cmd.Parameters.AddWithValue("@service_id", serviceID);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
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
    }
}
