using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class TariffHistory
    {
        private long _id;

        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private long _phoneID;

        public long PhoneID
        {
            get { return _phoneID; }
            set { _phoneID = value; }
        }

        private long _tariffID;

        public long TariffID
        {
            get { return _tariffID; }
            set { _tariffID = value;}
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate.ToLocalTime(); }
            set { _startDate = value; }
        }

        private DateTime? _endDate;

        public DateTime? EndDate
        {
            get { return _endDate == null ? null : (DateTime?)_endDate.Value.ToLocalTime(); }
            set { _endDate = value;}
        }

        private string _tariffName;

        public string TariffName
        {
            get { return _tariffName; }
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

    }
}
