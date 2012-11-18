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
            //TODO: Распарсить входящие значения и преобразовать в нужны формат
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
            List<Subscriber> searchResult = DatabaseUtils.SelectSubscribers(name.Trim(), patronymic.Trim(), surname.Trim(), phoneNumber.Trim(), d);

            //TODO: Через DatabaseUtils получить нужных абонентов, перегнать в строки, записать; если debt < 0, значит, выводятся абоненты с любым размером долга
            foreach (Subscriber s in searchResult)
            {
                string[] item = new string[6];
                item[0] = s.ID.ToString();
                item[1] = s.Surname;
                item[2] = s.Name;
                item[3] = s.Patronymic;
                item[4] = string.Empty;
                foreach (PhoneNumber n in DatabaseUtils.SelectPhoneNumbers(s))
                {
                    if (item[4] == string.Empty)
                        item[4] = n.Number;
                    else
                        item[4] += Environment.NewLine + n.Number;
                }
                item[5] = ((s.Balance > 0) ? Constants.No : (-s.Balance).ToString() + " " + Constants.Currency);
                result.Add(item);
            }/*
            for (int i = 0; i < 50; i++)
            {
                result.Add(new string[6]);
            }*/
            return result;
        }

        public void AddSubscriber()
        {
            FormSubscriber form = new FormSubscriber();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void EditSubscriber(long id)
        {
            FormSubscriber form = new FormSubscriber(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void ShowInfo(long id)
        {
            FormDetailedInf form = new FormDetailedInf(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
