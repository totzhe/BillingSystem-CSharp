using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    public static class BillingOperations
    {
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

        public static void ChargeCalls()
        {
            PhoneNumber number; //получить из БД по number
            //Price price = new Price(); //получить из БД по префиксу и number тарифа, полученного из tariff_history, полученного по дате
            //TimeSpan duration = call.EndTime - call.StartTime;
            //double cost = price.Cost * (duration.TotalSeconds);
            //спиcать деньги в БД
            DateTime lastChargeTime = DateTime.Now;
            DateTime currentTime = DateTime.Now;
            Service service = Service.SelectServiceByName(Constants.ChargeCalls);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(date) FROM charge WHERE service_id = @service_id", connection);
                cmd.Parameters.AddWithValue("@service_id", service.ID);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    lastChargeTime = r.IsDBNull(r.GetOrdinal("MAX(date)")) ? DateTime.MinValue : r.GetDateTime("MAX(date)");
                    //System.Windows.Forms.MessageBox.Show(lastChargeTime.ToString());
                }
                r.Close();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            List<PhoneNumber> phones = PhoneNumber.SelectAllPhoneNumbers();
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
                    }
                }
                if (sum > 0)
                {
                    Charge callsCharge = new Charge(pn, service, sum, currentTime);
                    callsCharge.WriteOff();
                }
            }
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
