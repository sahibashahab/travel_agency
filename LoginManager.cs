
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelAgencySystem
{
    class LoginManager
    {
        public void controlLogin(string username,string password) {
            Authentication authentication = new Authentication(username,password);
            string role = authentication.auth();



            if (role== "Admin")
            {
                LoginPart lp = new AdminWindow();
                lp.Accept(new ConcreateVisitor());
                
            }
            else if (role == "Owner")
            {
                LoginPart lp = new OwnerWindow();
                lp.Accept(new ConcreateVisitor());


            }
            else if (role == "Receptionist")
            {
                LoginPart lp = new Employeewindow();
                lp.Accept(new ConcreateVisitor());

            }
            else
            {
                
                MessageBox.Show("Invalid Email password");
            }


        }
    }
}
