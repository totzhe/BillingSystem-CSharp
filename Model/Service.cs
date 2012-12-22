using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс услуги связи.
    /// </summary>
    public class Service
    {
        private long _id;

        /// <summary>
        /// Возвращает идентификатор услуги.
        /// </summary>
        public long ID
        {
            get { return _id; }
        }

        private string _name;

        /// <summary>
        /// Возвращает наименование услуги.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        private double _cost;

        /// <summary>
        /// Возвращает стоимость пользования услугой.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
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

        /// <summary>
        /// Инициализирует новый экземпляр класса Service, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="id">Идентификатор услуги</param>
        /// <param name="name">Наименование</param>
        /// <param name="cost">Стоимость</param>
        private Service(long id, string name, double cost)
        {
            _id = id;
            _name = name;
            _cost = cost;
        }

        /// <summary>
        /// Получает услугу по ее наименованию.
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
        /// Получает из БД услугу по ее идентификатору.
        /// </summary>
        /// <param name="serviceID">Идентификатор услуги</param>
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
