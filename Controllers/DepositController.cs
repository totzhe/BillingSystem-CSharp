using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class DepositController: IControllers.IDepositController
    {
        private Subscriber _subscriber;
        public DepositController(long id)
        {
            _subscriber = Subscriber.SelectSubscriberByID(id);
        }

        public string GetFullName()
        {
            return _subscriber.GetFullName();
        }

        public string GetBalance()
        {
            return Math.Round(_subscriber.Balance, 2).ToString() + " " + Constants.Currency;
        }

        public void Confirm(string sum)
        {
            try
            {
                double d = Double.Parse(sum);
                _subscriber.DepositMoney(d);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Неверный формат суммы!");
            }
        }

        public void Cancel()
        {
        }
    }
}
