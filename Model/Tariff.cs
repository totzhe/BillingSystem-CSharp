using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс тарифного плана.
    /// </summary>
    public class Tariff
    {
        private long _id;

        /// <summary>
        /// Возвращает или задает идентификатор тарифа.
        /// </summary>
        public long ID
        {
            get { return _id; }
            set { }
        }

        private string _name;

        /// <summary>
        /// Возвращает или задает название тарифа.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { }
        }

        private string _description;

        /// <summary>
        /// Возвращает или задает описание тарифного плана.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { }
        }

        private bool _active;

        /// <summary>
        /// Состояние активности тарифа.
        /// </summary>
        public bool Active
        {
            get { return _active; }
            set { }
        }

        private List<Price> _price;
        /// <summary>
        /// Возвращаяет список цена тарифа
        /// </summary>
        public List<Price> Price
        {
            get { return _price; }
            set { }
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
        /// Инициализирует новый экземпляр класса Tariff, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        /// <param name="active">Состояние активности</param>
        public Tariff(long id, string name, string description, bool active)
        {
            _id = id;
            _name = name;
            _description = description;
            _active = active;
            _price = new List<Price>();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Tariff со списком цен
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        /// <param name="active">Состояние активности</param>
        /// <param name="price">Список цен</param>
        public Tariff(long id, string name, string description, bool active, List<Price> price)
        {
            _id = id;
            _name = name;
            _description = description;
            _active = active;
            _price = price;
        }

        /// <summary>
        /// Добавить тариф
        /// </summary>
        /// <param name="name">Название описание</param>
        /// <param name="description"></param>
        public static long Add(string name, string description)
        {
            long result = 0;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO tariff (name, description, active) VALUES (@name, @description, 1)", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                MySqlDataReader r = cmd.ExecuteReader();
                r.Close();

                MySqlCommand cmd2 = new MySqlCommand("SELECT MAX(id) as id FROM tariff", connection);
                MySqlDataReader r2 = cmd2.ExecuteReader();
                while (r2.Read())
                {
                    result = r2.GetInt64("id");
                }
                r2.Close();
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
        /// Получает тариф из БД по его идентификатору, паредаваемому в качестве параметра.
        /// </summary>
        /// <param name="tariffID">Идентификатор</param>
        /// <returns>Тариф</returns>
        public static Tariff SelectTariffByID(long tariffID)
        {
            Tariff result = null;
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tariff WHERE id = @tariffID", connection);
                cmd.Parameters.AddWithValue("@tariffID", tariffID);
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
        /// Получает из БД активные тарифы
        /// </summary>
        /// <returns>Список тарифов</returns>
        public static List<Tariff> SelectActiveTariff()
        {
            List<Tariff> result = new List<Tariff>();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tariff WHERE active > 0", connection);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result.Add(new Tariff(r.GetInt64("id"), r.GetString("name"), DatabaseUtils.GetStringOrNull(r, "description"), r.GetBoolean("active")));
                }
                r.Close();

                foreach (Tariff item in result)
                {
                    List<Price> price = new List<Price>();
                    MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM price WHERE tariff_id = @id", connection);
                    cmd2.Parameters.AddWithValue("@id", item.ID);
                    MySqlDataReader r2 = cmd2.ExecuteReader();
                    while (r2.Read())
                    {
                        price.Add(new Price(r2.GetInt64("tariff_id"), r2.GetString("prefix"), r2.GetFloat("cost")));
                    }
                    foreach (Price pitem in price)
                    {
                        item.Price.Add(pitem);
                    }
                    r2.Close();
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
        /// Изменяет данные о тарифе
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        public static void EditTariffData(long? id, string name, string description)
        {
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE tariff SET name = @name, description = @description WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                MySqlDataReader r = cmd.ExecuteReader();
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

        /// <summary>
        /// Возвращает стоимость звонка на определенные номера с указанным префиксом.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Price SelectCallPrice(string phone)
        {
            Price result = null;
            try
            {
                connection.Open();

                string query = "SELECT * FROM price WHERE tariff_id = @tariff_id AND @item LIKE CONCAT(prefix, '%') ORDER BY LENGTH(prefix) DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tariff_id", ID);
                cmd.Parameters.AddWithValue("@item", phone);

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
