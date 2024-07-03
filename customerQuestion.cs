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
    public partial class customerQuestion : Form
    {
        string type;
        public customerQuestion()
        {
            InitializeComponent();
        }
        public customerQuestion(string a)
        {
            type = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type=="Admin")
            {
                AbstractState obj = new AvailState();
                obj.req();
                this.Hide();
              //  AdminWindow adminWindow = new AdminWindow();
               // adminWindow.Hide();
                
            }
            else if(type=="employee")
            {
                AbstractState obj = new AvailState();
                obj.req();
               
                this.Hide();
            
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


            if (type == "Admin")
            {
                AbstractState obj = new NotAvailState();
                obj.req();
                this.Hide();
               ;
            }
            else if(type == "employee")
            {
                AbstractState obj = new NotAvailState();
                obj.req();

                this.Hide();
               

            }
        }
    }
}
