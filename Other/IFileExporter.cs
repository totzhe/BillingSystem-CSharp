using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Other
{
    public interface IFileExporter
    {

        /// <summary>
        /// Экспортирует детализацию звонков выбранного номера в указанный файл.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="beginningDate">Первый день периода, за который выводится история</param>
        /// <param name="endDate">Последний день периода, за который выводится история</param>
        /// <param name="items">Информация о звонках, которую необхоидмо экспортировать</param>
        void ExportCalls(string filename, string phoneNumber, DateTime beginningDate, DateTime endDate, List<string[]> items);

        /// <summary>
        /// Экспортирует детализацию операций выбранного номера в указанный файл.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="beginningDate">Первый день периода, за который выводится история</param>
        /// <param name="endDate">Последний день периода, за который выводится история</param>
        /// <param name="items">Информация о операциях, которую необхоидмо экспортировать</param>
        void ExportOperations(string filename, string phoneNumber, DateTime beginningDate, DateTime endDate, List<string[]> items);

        /// <summary>
        /// Экспортирует список должников в указанный файл
        /// </summary>
        /// <param name="filename">имя файла</param>
        /// <param name="date">Текущая дата</param>
        /// <param name="items">Информация о должниках, которую необходимо экспортировать</param>
        void ExportDebtors(string filename, DateTime date, List<string[]> items);
    }
}
