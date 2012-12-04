﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    public interface IDetailedInfController
    {
        /// <summary>
        ///Возвращает список телефонных номеров, имеющихся у пользователя
        /// </summary>
        /// <returns>Номера телефонов</returns>
        List<string> GetPhoneNumbers();

        /// <summary>
        /// Метод. Возвращает полное имя абонента
        /// </summary>
        /// <returns></returns>
        string GetSubscriberFullName();

        //// <summary>
        //// Метод. Осуществляет поиск абонентов по заданным параметрам
        //// </summary>
        //// <param name="phoneNumber">Телефонный номер</param>
        //// <param name="parameter">Параметр детализации</param>
        //// <param name="from">Дата начала периода</param>
        //// <param name="to">Дата конца периода</param>
        //// <returns></returns>
        List<string[]> Search(string phoneNumber, DateTime from, DateTime to);
    }
}
