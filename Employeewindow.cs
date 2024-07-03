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
    public partial class Employeewindow : Form,LoginPart
    {
        Facadepatt fp = new Facadepatt();
        public Employeewindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fp.ManagingCust("Emp");
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fp.TicketBooking("employee");
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            fp.Cancel("employee");
            this.Hide();
        }

        private void Employeewindow_Load(object sender, EventArgs e)
        {

        }

        public void Accept(AbstractVisitor ab)
        {
            ab.visit(this);
        }
    }
}
