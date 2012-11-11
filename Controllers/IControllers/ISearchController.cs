﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Controllers
{
    public interface ISearchController
    {
        /// <summary>
        /// Метод возвращяет список пользователей по заданным параметрам
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="patronymic">Отчество пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="phoneNumber">Номер пользователя</param>
        /// <param name="debt">Размер задолжености</param>
        /// <returns>Возвращает список массива строк</returns>
        List<string[]> Search(string name, string patronymic, string surname, string phoneNumber, string debt);

        /// <summary>
        /// Создает форму добавления пользователя
        /// </summary>
        void AddSubscriber();

        /// <summary>
        /// Создает форму редактирования пользователя
        /// </summary>
        /// <param name="id">id пользователя</param>
        void EditSubscriber(int id);

        /// <summary>
        /// Создает форму детализации пользователя
        /// </summary>
        /// <param name="id">id пользователя</param>
        void ShowInfo(int id);
    }
}
