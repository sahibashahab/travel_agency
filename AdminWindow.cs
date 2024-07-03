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
    public partial class AdminWindow : Form, LoginPart
    {
        Facadepatt fp = new Facadepatt();
        public AdminWindow()
        {

            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fp.MaintainInfo();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fp.ManagingEmp();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fp.ManagingCust("Admin");
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fp.TicketBooking("Admin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fp.Cancel("Admin");
            //this.Hide();
        }

        public void Accept(AbstractVisitor ab)
        {
            {

                ab.visit(this);
            }
        }
    }
}