using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BillingSystem
{
    /// <summary>
    /// Класс стартера программы.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Главная точка входа в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseUtils.Connect(Constants.ConnectionString);

            Application.Run(new FormSearch());
        }
    }
}
