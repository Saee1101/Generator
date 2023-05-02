using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Test
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
            var container = new StructureMap.Container(config =>
            {
                config.For<IRepository>().Use<Repository>();
            }
            );
            var mainform = container.GetInstance<Form1>();
            var financial = new M.FinancialYearModel();
            financial.date ="1402/01/02";
            var startDateYear = financial.date.Split('/')[0];
            var startDateMonth = financial.date.Split('/')[1];
            var startDateDay = financial.date.Split('/')[2];
            var Da = new Entities.Fault();
            Da.Date = new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay)
                , new PersianCalendar());
            Application.Run(mainform);
        }
    }
}
