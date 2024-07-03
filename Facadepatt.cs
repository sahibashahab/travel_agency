using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySystem
{
    class Facadepatt
    {
        TransportationSelection ts;
        customerQuestion question;
        ManagingEmployee me;
        MaintainCustomer mc;
        MaintainBooking mb;
        ShowReport SR;



        public void MaintainInfo()
        {
            ts = new TransportationSelection();
            ts.Show();

        }
        public void TicketBooking(string a)
        {
            question = new customerQuestion(a);

            question.Show();

        }
        public void ManagingEmp()
        {
            me = new ManagingEmployee();
            me.Show();
        }
        public void ManagingCust(string a)
        {
            mc = new MaintainCustomer(a);
            mc.Show();
        }
        public void Cancel(string a)
        {
            mb = new MaintainBooking(a);
            mb.Show();
        }
        public void report()
        {
            SR = new ShowReport();
            SR.Show();

        }
        

    }
}
