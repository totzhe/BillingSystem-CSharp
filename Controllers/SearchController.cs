using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.DataModel;
using BillingSystem.View;

namespace BillingSystem.Controllers
{
    public class SearchController: ISearchController
    {
        private DatabaseUtils _dbUtils;

        public SearchController()
        {
            _dbUtils = new DatabaseUtils();
        }

        public List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, string debt)
        {
            //TODO: Распарсить входящие значения и преобразовать в нужны формат

            List<string[]> result = new List<string[]>();

            //TODO: Через DatabaseUtils получить нужных абонентов, перегнать в строки, записать; если debt < 0, значит, выводятся абоненты с любым размером долга

            foreach (subscriber subs in _dbUtils.FindCustomerList("a"))
            {
                string[] s = new string[5];
                s[0] = subs.name;
                result.Add(s);
            }

            for (int i = 0; i < 50; i++)
            {
                result.Add(new string[5]);
            }
            return result;
        }

        public void AddSubscriber()
        {
            FormSubscriber form = new FormSubscriber();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void EditSubscriber(int id)
        {
            FormSubscriber form = new FormSubscriber(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void ShowInfo(int id)
        {
            FormDetailedInf form = new FormDetailedInf(id);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
