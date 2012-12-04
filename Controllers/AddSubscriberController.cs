using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class AddSubscriberController : SubscriberController
    {
        public AddSubscriberController() : base() { }


        /*public override void DeletePhoneNumber(string phoneNumber)
        {
            foreach (PhoneNumber n in _phonesToAdd)
            {
                if (n.Number == phoneNumber.Trim())
                {
                    _phonesToAdd.Remove(n);
                    return;
                }
            }
        }
        
        public override void ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name.Trim();
            subscriber.Patronymic = patronymic.Trim();
            subscriber.Surname = surname.Trim();
            subscriber.Email = email.Trim();
            subscriber.Login = login.Trim();
            subscriber.Add();
            foreach (PhoneNumber n in _phonesToAdd)
                n.Add();
        }*/
    }
}