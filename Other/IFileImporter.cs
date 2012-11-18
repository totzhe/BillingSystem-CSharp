using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Other
{
    public interface IFileImporter
    {
        /// <summary>
        /// Импортирует звонки из файла.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Список звонков</returns>
        List<Call> ImportCalls(string filename);

        /// <summary>
        /// Импортирует тарифы из файла.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Список тарифов</returns>
        List<Tariff> ImportTariffs(string filename);
    }
}
