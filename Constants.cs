using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem
{
    public static class Constants
    {
        public const string Currency = "руб.";

        public const string No = "Нет";

        public const string DefaultPasswordHash = "111";

        public const string ConnectionString = @"server=vragov.com;userid=billing;password=billing;database=billing;charset=utf8";

        public const string Incoming = "Входящий";
        public const string Outgoing = "Исходящий";

        public const string TariffChanging = "Смена тарифа";
        public const string NoInfo = "Неизвестно";
    }
}
