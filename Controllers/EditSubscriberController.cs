using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public class EditSubscriberController : SubscriberController
    {
        public EditSubscriberController(long subscriberID) : base(subscriberID) { }
        
        public override void ConfirmChanges(string name, string patronymic, string surname, string email, string login)
        {
            subscriber.Name = name == null ? Constants.NoInfo : name.Trim();
            subscriber.Patronymic = patronymic == null ? null : patronymic.Trim();
            subscriber.Surname = surname == null ? Constants.NoInfo : surname.Trim();
            subscriber.Email = email == null ? null : email.Trim();
            subscriber.Login = login == null ? null : login.Trim();
            subscriber.Update();
            foreach (PhoneNumber n in _phonesToUpdate)
                n.Update();
            foreach (PhoneNumber n in _phonesToAdd)
                n.Add();
            foreach (PhoneNumber n in _phonesToDelete)
                n.Delete();
        }       
    }
}
    
