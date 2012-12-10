using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public static class BillingOperations
    {
        /*private static MySqlConnection _connection;

        private static MySqlConnection connection
        {
            get
            {
                if (_connection == null)
                    _connection = ConnectionManager.GetConnection();
                return _connection;
            }
        }*/

        public static void ChargeCalls()
        {
            DateTime lastChargeTime = DateTime.Now;
            DateTime currentTime = DateTime.Now;
            Service service = Service.SelectServiceByName(Constants.ChargeCalls);

            lastChargeTime = Charge.GetLastChargeTime(service.ID);

            List<PhoneNumber> phones = PhoneNumber.SelectAllPhoneNumbers();
            double full_sum = 0;
            int phones_count = 0;
            int calls_count = 0;
            foreach (PhoneNumber pn in phones)
            {
                //System.Windows.Forms.MessageBox.Show(pn.Number);
                double sum = 0;
                List<Call> calls = pn.SelectCalls(lastChargeTime, currentTime);
                foreach (Call call in calls)
                {
                    if (call.CallingNumber == pn.Number)
                    {
                        Tariff tariff = pn.SelectTariffByDate(call.StartTime);
                        sum += CalculateCallCost(call, tariff);
                        calls_count++;
                    }
                }
                if (sum > 0)
                {
                    Charge callsCharge = new Charge(pn, service, sum, currentTime);
                    callsCharge.WriteOff();
                    full_sum += sum;
                    phones_count++;
                }
            }
            System.Windows.Forms.MessageBox.Show("Списано " + full_sum.ToString() + " " + Constants.Currency + " с " + phones_count.ToString() + " номеров за " + calls_count.ToString() + " звонков.", "Списание средств завершено");
        }

        public static double CalculateCallCost(Call call, Tariff tariff)
        {
            Price price = tariff.SelectCallPrice(call.CalledNumber);
            double cost = price.Cost * (call.Duration.TotalSeconds);
            //спиcать деньги в БД
            return Math.Round(cost, 2);
        }

        

        //TODO: какие-нибудь еще методы по мере необходимости
    }
}
