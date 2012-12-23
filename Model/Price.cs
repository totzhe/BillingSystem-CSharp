using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс цены за услуги связи.
    /// </summary>
    public class Price
    {
        private long _tariffID;

        /// <summary>
        /// Возвращает идентификатор тарифа.
        /// </summary>
        public long TariffID
        {
            get { return _tariffID; }
        }

        private string _prefix;

        /// <summary>
        /// Возвращает строку, содержащую префикс телефонного номера.
        /// </summary>
        public string Prefix
        {
            get { return _prefix; }
        }

        private double _cost;

        /// <summary>
        /// Возвращает стоимость.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Price, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="tariffID">Идентификатор тарифа</param>
        /// <param name="prefix">Префикс номера телефона</param>
        /// <param name="cost">Стоимость</param>
        public Price(long tariffID, string prefix, float cost)
        {
            _tariffID = tariffID;
            _prefix = prefix;
            _cost = cost;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Price, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="prefix">Префикс номера телефона</param>
        /// <param name="cost">Стоимость</param>
        public Price(string prefix, float cost)
        {
            _prefix = prefix;
            _cost = cost;
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
        /// Изменяет цены тарифов
        /// </summary>
        /// <param name="id">id тарифы</param>
        /// <param name="dgv">DataGrid c ценами</param>
        public static void EditPrice(long? id, DataGridView dgv)
        {
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM price WHERE tariff_id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader r = cmd.ExecuteReader();
                r.Close();

                foreach (DataGridViewRow item in dgv.Rows)
                {
                    //MessageBox.Show(item.Cells[0].Value.ToString());
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO price (tariff_id, prefix, cost) VALUES (@tariff_id, @prefix, @cost)", connection);
                    cmd2.Parameters.AddWithValue("@tariff_id", id);
                    cmd2.Parameters.AddWithValue("@prefix", item.Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("@cost", System.Convert.ToDouble(item.Cells[1].Value.ToString()));
                    MySqlDataReader r2 = cmd2.ExecuteReader();
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
        }

    }
}
