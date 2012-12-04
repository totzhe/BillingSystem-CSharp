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
            get { return _startTime.ToLocalTime(); }
            set { }
        }

        private DateTime _endTime;

        public DateTime EndTime
        {
            get { return _endTime.ToLocalTime(); }
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

        public Call(long id, string callingNumber, string calledNumber, DateTime startTime, DateTime endTime)
        {
            _id = id;
            _callingNumber = callingNumber;
            _calledNumber = calledNumber;
            _startTime = startTime.ToUniversalTime();
            _endTime = endTime.ToUniversalTime();
        }


        // TODO: Добавить конструкторы в зависимости от того, как объекты будут читаться из БД
        // TODO: Добавить методы по мере необходимости
    }
}
