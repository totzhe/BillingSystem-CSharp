using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface ISubscriberController
    {
        //ISubscriberController(int id); //ищет абонента в БД

        string getName();

        string getSurname();

        string getPatronymic();

        string getEmail();

        string getLogin();

        List<string> getPhoneNumbers();

        void AddPhoneNumber();

        void EditPhoneNumber(string phoneNumber);

        void DeletePhoneNumber(string phoneNumber);

        void ResetPassword();

        void ConfirmChanges(string name, string patronymic, string surname, string email, string login);

        void Cancel();
    }
}
