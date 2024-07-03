using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class ConcreateVisitor : AbstractVisitor
    {
        public  void visit(OwnerWindow Ow)
        { 
            OwnerWindow ow = new OwnerWindow();
            ow.Show();
        }

        public void visit(AdminWindow Aw)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
        }

        public  void visit(Employeewindow e)
        {
            Employeewindow ew = new Employeewindow();
            ew.Show();
        }
    }
}
