using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class ReportViewManager
    {

        public void getSaleReport(DateTimePicker from,DateTimePicker too,DataGridView Show)
        {
            ViewReport v = new ViewReport(from.Value.ToShortDateString(), too.Value.ToShortDateString(), Show);
            v.getSaleReport();


        }

        public void getEmployeeReport(DateTimePicker from, DateTimePicker too, DataGridView Show)
        {
            ViewReport v = new ViewReport(from.Value.ToShortDateString(), too.Value.ToShortDateString(), Show);
            v.getEmployeeReport();


        }

        public void getCustomerReport(DateTimePicker from, DateTimePicker too, DataGridView Show)
        {
            ViewReport v = new ViewReport(from.Value.ToShortDateString(), too.Value.ToShortDateString(), Show);
            v.getCustomerReport();


        }

        

    }
}
