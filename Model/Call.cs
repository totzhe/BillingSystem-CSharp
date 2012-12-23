using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс звонка.
    /// </summary>
    public class Call
    {
        private long _id;

        /// <summary>
        /// Возвращает идентификатор звонка.
        /// </summary>
        public long ID
        {
            get { return _id; }
        }

        private string _callingNumber;

        /// <summary>
        /// Возвращает строку, содержащую номер телефона вызывающего абонента.
        /// </summary>
        public string CallingNumber
        {
            get { return _callingNumber; }
        }

        private string _calledNumber;

        /// <summary>
        /// Возвращает строку, содержащую номер телефона вызываемого абонента.
        /// </summary>
        public string CalledNumber
        {
            get { return _calledNumber; }
        }

        private DateTime _startTime;

        /// <summary>
        /// Возвращает время начала разговора.
        /// </summary>
        public DateTime StartTime
        {
            get { return _startTime; }
        }

        private DateTime _endTime;

        /// <summary>
        /// Возвращает время окончания разговора.
        /// </summary>
        public DateTime EndTime
        {
            get { return _endTime; }
        }

        /// <summary>
        /// Возвращает длительность разговора.
        /// </summary>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса Call, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="callingNumber">Телефонный номер вызывающего абонента</param>
        /// <param name="calledNumber">Телефонный номер вызываемого абонента</param>
        /// <param name="startTime">Время начала разговора</param>
        /// <param name="endTime">Время завершения разговора</param>
        public Call(string callingNumber, string calledNumber, DateTime startTime, DateTime endTime)
        {
            _callingNumber = callingNumber;
            _calledNumber = calledNumber;
            _startTime = startTime;
            _endTime = endTime;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Call, получая в качестве аргументов следующие параметры:
        /// </summary>
        /// <param name="id">Идентификатор звонка</param>
        /// <param name="callingNumber">Телефонный номер вызывающего абонента</param>
        /// <param name="calledNumber">Телефонный номер вызываемого абонента</param>
        /// <param name="startTime">Время начала разговора</param>
        /// <param name="endTime">Время завершения разговора</param>
        public Call(long id, string callingNumber, string calledNumber, DateTime startTime, DateTime endTime)
        {
            _id = id;
            _callingNumber = callingNumber;
            _calledNumber = calledNumber;
            _startTime = startTime;
            _endTime = endTime;
        }

        /// <summary>
        /// Добавляет запись с данными о звонке в базу данных.
        /// </summary>
        public void Add()
        {
            try
            {
                connection.Open();
                string queryString = "INSERT INTO calls (calling_number, called_number, start_time, end_time) VALUES (@callingNumber, @calledNumber, @startTime, @endTime)";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
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

        /// <summary>
        /// Возвращает основную информацию о звонках для последующего импорта в файл. 
        /// </summary>
        /// <returns>Словарь значений</returns>
        public Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(Constants.Outgoing, CallingNumber);
            result.Add(Constants.Incoming, CalledNumber);
            result.Add(Constants.StartTime, StartTime.ToString());
            result.Add(Constants.EndTime, EndTime.ToString());
            return result;
        }
    }
}
