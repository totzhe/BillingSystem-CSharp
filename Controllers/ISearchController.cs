using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface ISearchController
    {
        List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, double debt);

        void AddSubscriber();

        void EditSubscriber(int id);

        void ShowInfo(int id);
    }
}
