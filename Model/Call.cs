using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public class Call
    {
        private long? _id;

        public long? ID
        {
            get { return _id; }
        }

        private string _callingNumber;

        public string CallingNumber
        {
            get { return _callingNumber; }
            set { }
        }

        private string _calledNumber;

        public string CalledNumber
        {
            get { return _calledNumber; }
            set { }
        }

        private DateTime _startTime;

        public DateTime StartTime
        {
            get { return _startTime/*.ToLocalTime()*/; }
            set { }
        }

        private DateTime _endTime;

        public DateTime EndTime
        {
            get { return _endTime/*.ToLocalTime()*/; }
            set { }
        }

        public TimeSpan Duration
        {
            get
            {
                if (_startTime != null && _endTime != null)
                    return EndTime - StartTime;
                else
                    return new TimeSpan(0, 0, 0);
            }
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

        public Call(long? id, string callingNumber, string calledNumber, DateTime startTime, DateTime endTime)
        {
            _id = id;
            _callingNumber = callingNumber;
            _calledNumber = calledNumber;
            _startTime = startTime;
            _endTime = endTime;
        }

        public void Add()
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO calls (id, calling_number, called_number, start_time, end_time) VALUES (@id, @callingNumber, @calledNumber, @startTime, @endTime)";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@callingNumber", _callingNumber);
                cmd.Parameters.AddWithValue("@calledNumber", _calledNumber);
                cmd.Parameters.AddWithValue("@startTime", _startTime);
                cmd.Parameters.AddWithValue("@endTime", _endTime);
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

        // TODO: Добавить конструкторы в зависимости от того, как объекты будут читаться из БД
        // TODO: Добавить методы по мере необходимости
    }
}
