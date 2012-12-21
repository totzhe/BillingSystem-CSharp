using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kent.Boogaart.KBCsv;
using Kent.Boogaart.HelperTrinity;
using System.IO;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс экспорта в файл.
    /// </summary>
    public static class FileExporter
    {
        /// <summary>
        /// Сохраняет DataGridView в CSV в файл с указанным именем.
        /// </summary>
        /// <param name="dgvInf">Таблица DataGridView</param>
        /// <param name="filename">Имя файла</param>
        public static void DGVtoCSV(DataGridView dgvInf, string filename)
        {
            using (CsvWriter writer = new CsvWriter(filename))
            {
                writer.ValueSeparator = Char.Parse(";");

                string[] dataString = new string[dgvInf.ColumnCount];

                for (int i = 0; i < dgvInf.RowCount; i++)
                {
                    for (int b = 0; b < dgvInf.ColumnCount; b++)
                    {
                        dataString[b] = dgvInf.Rows[i].Cells[b].Value.ToString();
                    }
                    writer.WriteDataRecord(dataString);
                }

                writer.Close();
            }
        }

        /// <summary>
        /// Преобразует CSV файл в список.
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Список строк</returns>
        public static List<string[]> CSVtoList(string filename)
        {
            List<string[]> list = new List<string[]>();

            using (var reader = new CsvReader(filename))
            {
                reader.ValueSeparator = Char.Parse(";");

                foreach (string[] record in reader.DataRecordsAsStrings)
                {
                    list.Add(record);
                }

                reader.Close();
            }

            return list;
        }

        /// <summary>
        /// Преобразует содержимое DataGridView, переданного в качестве парметра, в HTML-страницу
        /// </summary>
        /// <param name="dgvInf">Таблица</param>
        /// <param name="from">Дата начала периода</param>
        /// <param name="to">Дата конца периода</param>
        /// <param name="subscriberFullName">ФИО абонента</param>
        /// <param name="phoneNumber">Телефонный номер</param>
        /// <param name="totalSum">Итог</param>
        /// <param name="fileName">Имя файла</param>
        public static void DetailedInfToHtml(DataGridView dgvInf, DateTime from, DateTime to, string subscriberFullName,
            string phoneNumber, double totalSum, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");
                writer.WriteLine("<title>Детализация за период с " + from.ToShortDateString() + " по "
                    + to.ToShortDateString() + "</title>");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<div align='center'><font size='5'><b>Детализированная информация</b></font></div>");
                writer.WriteLine("<div align='center'><font size='3'>за период с " + from.ToShortDateString() + " по " + to.ToShortDateString() + "</div>");
                writer.WriteLine("<br>");
                writer.WriteLine("<div align='left'>ФИО абонента: " +  subscriberFullName + "</div>");
                writer.WriteLine("<div align='left'>Абонентский номер: " + phoneNumber + "</div>");
                writer.WriteLine("<table width='100%' border='1' cellspacing='0'>");
                
                for (int i = 0; i <= dgvInf.RowCount; i++)
                {
                    writer.WriteLine("<tr align='center' valign='middle'>");
                    for (int j = 0; j < dgvInf.ColumnCount; j++)
                    {
                        if (i == 0)
                        {
                            writer.WriteLine("<td><b>" + dgvInf.Columns[j].HeaderText + "</b></td>");
                        }
                        else
                        {
                            writer.WriteLine("<td>" + dgvInf.Rows[i-1].Cells[j].Value.ToString() + "</td>");
                        } 
                    }
                    writer.WriteLine("</tr>");
                }
                
                writer.WriteLine("<tr>");
                writer.WriteLine("<td colspan=");
                writer.WriteLine("'" + (dgvInf.ColumnCount - 1).ToString() + "'></td>");
                writer.WriteLine("<td><b>Итого: ");
                writer.WriteLine(totalSum.ToString() + "</b></td>");
                writer.WriteLine("</tr>");
                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
                writer.Close();
            }
        }
    }
}
