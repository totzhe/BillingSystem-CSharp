using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Model;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Интерфейс контроллера импорта звонков.
    /// </summary>
    public interface ICallsImportController
    {
        /// <summary>
        /// Открывает файл с указанным именем.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        void OpenFile(string filename);
        
        /// <summary>
        /// Добавляет звонок.
        /// </summary>
        void AddCall();
        
        /// <summary>
        /// Возвращает звонки.
        /// </summary>
        /// <returns>Звонки</returns>
        List<Dictionary<string, string>> GetCalls();
        
        /// <summary>
        /// Создает звонки со случайными значениями.
        /// </summary>
        /// <param name="count">Количество звонков</param>
        void RndCall(int count);
    }
}
