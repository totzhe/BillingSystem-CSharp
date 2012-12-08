using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;
using BillingSystem.View;

namespace BillingSystem.Controllers
{
    public class SearchController: ISearchController
    {
        public List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, string debt)
        {
            List<string[]> result = new List<string[]>();
            //TODO: Распарсить входящие значения и преобразовать в нужный формат
            double d;
            if (debt != string.Empty)
            {
                try
                {
                    d = Double.Parse(debt);
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Неверный формат размера долга!");
                    return result;
                }
            }
            else
                d = 0;
            List<Subscriber> searchResult = Subscriber.SelectSubscribers(name.Trim(), patronymic.Trim(), surname.Trim(), phoneNumber.Trim(), d);

            //TODO: Через DatabaseUtils получить нужных абонентов, перегнать в строки, записать; если debt < 0, значит, выводятся абоненты с любым размером долга
            foreach (Subscriber s in searchResult)
            {
                string[] item = new string[6];
                item[0] = s.ID.ToString();
                item[1] = s.Surname;
                item[2] = s.Name;
                item[3] = s.Patronymic;
                item[4] = string.Empty;
                foreach (PhoneNumber n in s.GetPhoneNumbers())
                {
                    if (item[4] == string.Empty)
                        item[4] = n.Number;
                    else
                        item[4] += Environment.NewLine + n.Number;
                }
                item[5] = ((s.Balance >= 0) ? Constants.No : (Math.Round(-s.Balance, 2)).ToString() + " " + Constants.Currency);
                result.Add(item);
                
            }
            return result;
        }

        public void AddSubscriber()
        {
            AddSubscriberController controller = new AddSubscriberController();
            FormSubscriber form = new FormSubscriber(controller);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                controller.Cancel();
            }
        }

        public void EditSubscriber(long id)
        {
            EditSubscriberController controller = new EditSubscriberController(id);
            FormSubscriber form = new FormSubscriber(controller);
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
            else
            {
                controller.Cancel();
            }
        }

        public void ShowInfo(long id)
        {
            FormDetailedInf form = new FormDetailedInf(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void Deposit(long id)
        {
            FormDeposit form = new FormDeposit(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
