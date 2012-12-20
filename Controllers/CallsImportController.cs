using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Model;
using BillingSystem.View;

namespace BillingSystem.Controllers
{
    /// <summary>
    /// Класс контроллера импорта звонков. Реализует интерфейс BillingSystem.Controllers.IControllers.ICallsImportController.
    /// </summary>
    public class CallsImportController : ICallsImportController 
    {
        private List<Call> _listCall = new List<Call>();
        
        private Random rnd = new Random();

        /// <summary>
        /// Открывает файл с указанным именем.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        public void OpenFile(string filename)
        {
            _listCall = new List<Call>();
            
            List<string[]> _items = FileExporter.CSVtoList(filename);
            foreach (string[] item in _items)
            {
                _listCall.Add(new Call(item[0], item[1], DateTime.Parse(item[2]), DateTime.Parse(item[3])));
            }
        }

        /// <summary>
        /// Добавляет звонок.
        /// </summary>
        public void AddCall()
        {
            foreach (Call item in _listCall)
            {
                item.Add();
            }
        }

        /// <summary>
        /// Получает информацию об импортируемых звонках.
        /// </summary>
        /// <returns>Звонки</returns>
        public List<Dictionary<string, string>> GetCalls()
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach (Call call in _listCall)
            {
                result.Add(call.ToDictionary());
            }
            return result;
        }

        /// <summary>
        /// Создает звонок со случайными значениями.
        /// </summary>
        /// <param name="count">Количество</param>
        public void RndCall(int count)
        {
            DateTime to = DateTime.Now;
            DateTime from = new DateTime(to.Year, to.Month, 1, 0, 0, 0, 0);
            List<PhoneNumber> listPN = PhoneNumber.SelectAllPhoneNumbers();
            for (int i = 0; i < count; i++)
            {
                int rnd1 = rnd.Next(listPN.Count);
                int rnd2 = rnd.Next(listPN.Count);
                while (rnd1 == rnd2)
                {
                    rnd2 = rnd.Next(listPN.Count);
                }
                TimeSpan delta = to - from;
                int rnd3 = rnd.Next((int)(delta.TotalSeconds));
                int rnd4 = rnd.Next(3600);
                DateTime start = from.AddSeconds(rnd3);
                DateTime finish = start.AddSeconds(rnd4);
                if (finish > to)
                    finish = DateTime.Now;
                _listCall.Add(new Call(listPN[rnd1].Number, listPN[rnd2].Number, start, finish));
            }
        }
    }
}
