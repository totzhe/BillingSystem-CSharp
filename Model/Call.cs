using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public class Call
    {
        private long _id;

        public long ID
        {
            get { return _id; }
        }

        private string _callingNumber;

        public string CallingNumber
        {
            get { return _callingNumber; }
            set { /*_callingNumber = value;*/ }
        }

        private string _calledNumber;

        public string CalledNumber
        {
            get { return _calledNumber; }
            set { /*_calledNumber = value;*/ }
        }

        private DateTime _startTime;

        public DateTime StartTime
        {
            get { return _startTime.ToLocalTime(); }
            set { /*_startDate = value;*/ }
        }

        private DateTime _endTime;

        public DateTime EndTime
        {
            get { return _endTime.ToLocalTime(); }
            set { /*_endDate = value;*/ }
        }

        public Call(long id, string callingNumber, string calledNumber, DateTime startTime, DateTime endTime)
        {
            _id = id;
            _callingNumber = callingNumber;
            _calledNumber = calledNumber;
            _startTime = startTime;
            _endTime = endTime;
        }


        // TODO: Добавить конструкторы в зависимости от того, как объекты будут читаться из БД
        // TODO: Добавить методы по мере необходимости
    }
}
