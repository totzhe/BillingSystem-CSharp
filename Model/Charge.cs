﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class Charge
    {
        private long _id;

        public long ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private long _phoneID;

        public long PhoneID
        {
            get { return _phoneID; }
            set { /*_phoneID = value;*/ }
        }

        private long _serviceID;

        public long OperationID
        {
            get { return _serviceID; }
            set { /*_serviceID = value;*/ }
        }

        private double _sum;

        public double Sum
        {
            get { return _sum; }
            set { /*_sum = value;*/ }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date/*.ToLocalTime()*/; }
            set { /*_date = value;*/ }
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

        public Charge(PhoneNumber phone, Service service, double sum, DateTime date)
        {
            _date = date;
            _phoneID = phone.ID;
            _serviceID = service.ID;
            _sum = sum + service.Cost;
            _phoneNumber = phone;
        }

        public Charge(long id, long phoneID, long serviceID, double sum, DateTime date)
        {
            _id = id;
            _phoneID = phoneID;
            _serviceID = serviceID;
            _sum = sum;
            _date = date;
        }

        /// <summary>
        /// Получает услугу
        /// </summary>
        /// <returns>Услуга</returns>
        public Service GetService()
        {
            return Service.SelectServiceByID(_serviceID);
        }

        /// <summary>
        /// Списывает деньги за услугу со счета абонента.
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

        public static DateTime GetLastChargeTime(long serviceID)
        {
            DateTime result = DateTime.MinValue;
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(date) FROM charge WHERE service_id = @service_id", connection);
                cmd.Parameters.AddWithValue("@service_id", serviceID);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = r.IsDBNull(r.GetOrdinal("MAX(date)")) ? DateTime.MinValue : r.GetDateTime("MAX(date)");
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
    }
}
