using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kent.Boogaart.KBCsv;
using Kent.Boogaart.HelperTrinity;

namespace BillingSystem.Model
{
    /// <summary>
    /// Класс экспорта из файла.
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
    }
}
