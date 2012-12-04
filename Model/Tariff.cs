using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class Tariff
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

        private string _description;

        public string Description
        {
            get { return _description; }
            set { /*_description = value;*/ }
        }

        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { /*_active = value;*/ }
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

        public Tariff(long id, string name, string description, bool active)
        {
            _id = id;
            _name = name;
            _description = description;
            _active = active;
        }



        /// <summary>
        /// Получает тариф из БД по его tariffID.
        /// </summary>
        /// <param name="tariffID">tariffID тарифа</param>
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
        /// Получает из БД активные тарифы с указанным именем.
        /// </summary>
        /// <param name="tariffName">Имя или часть имени тарифа</param>
        /// <returns>Список тарифов</returns>
        public static List<Tariff> SelectActiveTariffsByName(string tariffName)
        {
            List<Tariff> result = new List<Tariff>();

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tariff WHERE active > 0 AND LOWER(name) LIKE LOWER('%" + tariffName + "%') ORDER BY name", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Tariff(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "description"), r.GetBoolean("active")));
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

        public Price SelectCallPrice(string phone)
        {
            Price result = null;
            try
            {
                connection.Open();

                string query = "SELECT * FROM price WHERE tariff_id = @tariff_id AND @phone LIKE CONCAT(prefix, '%') ORDER BY LENGTH(prefix) DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tariff_id", ID);
                cmd.Parameters.AddWithValue("@phone", phone);

                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result = new Price(r.GetInt64("tariff_id"), r.GetString("prefix"), r.GetFloat("cost"));
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
