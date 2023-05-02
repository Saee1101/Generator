using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinent.Test
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
            cli
            //var financial = new Models.FinancialYearModel();
            //financial.date = picker.SelectedDate.ToString("yyyy/MM/dd");
            //var startDateYear = financial.date.Split('/')[0];
            //var startDateMonth = financial.date.Split('/')[1];
            //var startDateDay = financial.date.Split('/')[2];
            //var Da = new Entities.Fault();
            //Da.Date = new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay)
            //    , new PersianCalendar());
            Application.Run(new Form1());
            
        }
    }
}
