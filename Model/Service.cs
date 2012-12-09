﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class Service
    {
        private long _id;

        public long ID
        {
            get { return _id; }
            set { /*_id = value;*/ }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { /*_name = value;*/ }
        }

        private double _cost;

        public double Cost
        {
            get { return _cost; }
            set { /*_cost = value;*/ }
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

        private Service(long id, string name, double cost)
        {
            _id = id;
            _name = name;
            _cost = cost;
        }

        /*/// <summary>
        /// Получает из БД услугу смены тарифа
        /// </summary>
        /// <returns>Услуга смены тарифа</returns>
        public static Service SelectChangeTariffService()
        {
            Service result = null;
            try
            {
                connection.Open();

                string query = "SELECT * FROM service WHERE LOWER(name) LIKE LOWER(@name) ORDER BY LENGTH(name) ASC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", Constants.TariffChanging);

                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Service(r.GetInt64("id"), r.GetString("name"), r.GetDouble("cost"));
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
        }*/

        /// <summary>
        /// Получает услугу по ее имени
        /// </summary>
        /// <param name="name">Имя услуги</param>
        /// <returns>Услуга</returns>
        public static Service SelectServiceByName(string name)
        {
            Service result = null;
            try
            {
                connection.Open();

                string query = "SELECT * FROM service WHERE LOWER(name) LIKE LOWER(@name) ORDER BY LENGTH(name) ASC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Service(r.GetInt64("id"), r.GetString("name"), r.GetDouble("cost"));
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
        /// Получает из БД услугу по ее ID
        /// </summary>
        /// <param name="serviceID">ID услуги</param>
        /// <returns>Услуга</returns>
        public static Service SelectServiceByID(long serviceID)
        {
            Service searchResult = null;
            try
            {
                connection.Open();
                string query = @"SELECT * FROM service WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", serviceID);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    searchResult = new Service(r.GetInt64("id"), r.GetString("name"), r.GetDouble("cost"));
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
    }
}
