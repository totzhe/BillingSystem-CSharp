using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Model
{
    public static class BillingOperations
    {
        public static void ChargeCallCost(Call call)
        {
            PhoneNumber number; //получить из БД по id
            Price price = new Price(); //получить из БД по префиксу и id тарифа, полученного из tariff_history, полученного по дате
            TimeSpan duration = call.EndTime - call.StartTime;
            double cost = price.Cost * (duration.TotalSeconds);
            //спиcать деньги в БД
        }

        //TODO: какие-нибудь еще методы по мере необходимости
    }
}
