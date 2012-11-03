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
        public List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, double debt)
        {
            List<string[]> result = new List<string[]>();
            //TODO: Через DatabaseUtils получить нужных абонентов, перегнать в строки, записать; если debt < 0, значит, выводятся абоненты с любым размером долга
            for(int i = 0; i < 5; i++)result.Add(new string[6]);
            //
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
