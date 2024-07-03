using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelAgencySystem
{
    class adopter : Target
    {
        string type;
        int a;
        public adopter(string type,int a)
        {
            this.type = type;
            this.a = a;

        }

        public override void request()
        {
            if (type == "Admin")
            {
                MaintainCustomer customer = new MaintainCustomer(type, a);
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Hide();
                customer.Show();
            }
            else if (type == "employee")
            {
                MaintainCustomer customer = new MaintainCustomer(type,a);
                Employeewindow ew = new Employeewindow();
                ew.Hide();
                customer.Show();

            }
        }
    }
}
