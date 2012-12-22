using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс истории тарифов.
    /// </summary>
    public class TariffHistory
    {
        private long _id;

        /// <summary>
        /// Возвращает идентификатор смены тарифа.
        /// </summary>
        public long ID
        {
            get { return _id; }
        }

        private long _phoneID;

        /// <summary>
        /// Возвращает идентификатор телефонного номера.
        /// </summary>
        public long PhoneID
        {
            get { return _phoneID; }
        }

        private long _tariffID;

        /// <summary>
        /// Возвращает идентификатор тарифного плана.
        /// </summary>
        public long TariffID
        {
            get { return _tariffID; }
        }

        private DateTime _startDate;

        /// <summary>
        /// Возвращает дату подключения тарифа.
        /// </summary>
        public DateTime StartDate
        {
            get { return _startDate; }
        }

        private DateTime? _endDate;

        /// <summary>
        /// Возвращает дату отключения тарифа.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate == null ? null : (DateTime?)_endDate.Value; }
        }

        private string _tariffName;

        /// <summary>
        /// Возвращает название тарифного плана.
        /// </summary>
        public string TariffName
        {
            get { return _tariffName; }
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

        public TariffHistory(long id, long phoneID, long tariffID, string tariffName,
            DateTime startDate, DateTime? endDate)
        {
            _id = id;
            _phoneID = phoneID;
            _tariffID = tariffID;
            _tariffName = tariffName;
            _startDate = startDate;
            _endDate = endDate;
        }

        public TariffHistory(long phoneID, long tariffID, DateTime startDate, DateTime? endDate)
        {
            _phoneID = phoneID;
            _tariffID = tariffID;
            _startDate = startDate;
            _endDate = endDate;
        }

    }
}
