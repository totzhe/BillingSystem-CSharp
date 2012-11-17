using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BillingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseUtils.Connect(@"server=vragov.com;userid=billing;password=billing;database=billing");

            Application.Run(new FormSearch());
        }
    }
}
