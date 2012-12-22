using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс биллинговых операций.
    /// </summary>
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

        /// <summary>
        /// Возвращает расчет списаний за звонки
        /// </summary>
        /// <param name="from">Начальная дата</param>
        /// <param name="to">Конечная дата</param>
        /// <returns>Списания</returns>
        public static List<Charge> CalculateCallsCharges(DateTime from, DateTime to)
        {
            Service service = Service.SelectServiceByName(Constants.ChargeCalls);
            List<PhoneNumber> phones = PhoneNumber.SelectAllPhoneNumbers();
            double full_sum = 0;
            int phones_count = 0;
            //int calls_count = 0;
            List<Charge> result = new List<Charge>();
            foreach (PhoneNumber pn in phones)
            {
                double sum = 0;

                try
                {
                    connection.Open();
                    string query = @"
                    SELECT SUM(TIMESTAMPDIFF(SECOND, c.start_time, c.end_time) *
                    (
                        SELECT cost FROM price 
                        WHERE
                        (
                            tariff_id = 
                            (
                                SELECT tariff_id FROM tariff_history 
                                WHERE phone_id = @phone_id AND start_date <= c.start_time AND (end_date > c.start_time OR end_date IS NULL)
                            )
                            AND c.called_number LIKE CONCAT(prefix, '%') 
                        )
                        ORDER BY LENGTH(prefix) DESC LIMIT 1
                    )
                    ) as sum FROM calls c WHERE calling_number LIKE(@number) AND end_time IS NOT NULL AND start_time >= @from AND start_time <= @to";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@phone_id", pn.ID);
                    cmd.Parameters.AddWithValue("@number", pn.Number);
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);
                    MySqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        sum = r.IsDBNull(r.GetOrdinal("sum")) ? 0 : r.GetDouble("sum");
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
                /*List<Call> calls = pn.SelectCalls(from, to);
                foreach (Call call in calls)
                {
                    if (call.CallingNumber == pn.Number)
                    {
                        Tariff tariff = pn.SelectTariffByDate(call.StartTime);
                        sum += CalculateCallCost(call, tariff);
                        calls_count++;
                    }
                }*/
                if (sum > 0)
                {
                    DateTime time = (to.Month == DateTime.Now.Month && to.Year == DateTime.Now.Year || to > DateTime.Now) ? DateTime.Now : to;
                    Charge callsCharge = new Charge(pn, service, sum, time);
                    result.Add(callsCharge);
                    full_sum += sum;
                    phones_count++;
                }
            }
            full_sum = Math.Round(full_sum, 2);
            System.Windows.Forms.MessageBox.Show("Будет списано " + full_sum.ToString() + " " + Constants.Currency + " с " + phones_count.ToString() + " номеров.", "Расчет завершен");
            return result;
        }

        /// <summary>
        /// Рассчитывает стоимость звонка.
        /// </summary>
        /// <param name="call">Звонок</param>
        /// <param name="tariff">Тариф</param>
        /// <returns>Стоимость</returns>
        public static double CalculateCallCost(Call call, Tariff tariff)
        {
            Price price = tariff.SelectCallPrice(call.CalledNumber);
            double cost = price.Cost * (call.Duration.TotalSeconds);
            return Math.Round(cost, 2);
        }


        //TODO: какие-нибудь еще методы по мере необходимости
    }
}