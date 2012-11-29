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
            //Price price = new Price(); //получить из БД по префиксу и id тарифа, полученного из tariff_history, полученного по дате
            TimeSpan duration = call.EndTime - call.StartTime;
            //double cost = price.Cost * (duration.TotalSeconds);
            //спиcать деньги в БД
        }

        public static double CalculateCallCost(Call call, Tariff tariff)
        {
            Price price = DatabaseUtils.SelectPrice(tariff, call.CalledNumber);
            double cost = price.Cost * (call.Duration.TotalSeconds);
            //спиcать деньги в БД
            return Math.Round(cost, 2);
        }

        

        //TODO: какие-нибудь еще методы по мере необходимости
    }
}
