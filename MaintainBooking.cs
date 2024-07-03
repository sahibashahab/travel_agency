using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    public partial class MaintainBooking : Form
    {
        
        string routeID;
        TicketInformationManager ticketInfo;
        string type;
        Ticket t1;
       

        public MaintainBooking(string ri,string nos,string classType,string type)
        {
            this.type = type;
            InitializeComponent();
            routeID = ri;
            label26.Text = nos;
            label32.Text = classType;
           
            
        }
        public MaintainBooking()
        {
            InitializeComponent();
        }
        public MaintainBooking(string a)
        {
            type = a;
            InitializeComponent();
        }

        private void cb_customer_DropDown(object sender, EventArgs e)
        {
            MaintainCustomerManager obj = new MaintainCustomerManager();
            cb_customer.Items.Clear();
             obj.SelectValueCombo(cb_customer);
          
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            try {

                ticketInfo = new TicketInformationManager();

                ticketInfo.getValues(Convert.ToInt32(routeID), label28, label27, label30, label31, label29, label33);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Select Value");
            }
        }

        private void btn_Confrm_Click(object sender, EventArgs e)
        {
            t1 = new Ticket(int.Parse(cb_customer.Text), DateTime.Today.Date.ToShortDateString(), routeID, int.Parse(label26.Text), label32.Text);
            t1.BookTicket();
            t1.Empa("Employee");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
            Ticket clone = t1.cloneTicket();
            clone.Empa("Client");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (type=="Admin")
            {
                SearchTicketAvailibility sta = new SearchTicketAvailibility();
                sta.Show();
                this.Hide();
            }
            else if(type== "employee")
            {
                Employeewindow ew = new Employeewindow();
                ew.Show();
                this.Hide();
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            ticketInfo = new TicketInformationManager();
            comboBox2.Items.Clear();
            ticketInfo.BookID(comboBox2);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

     
        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // ticketInfo = new TicketInformationManager();
            // ticketInfo.GetPrint(e);
            t1 = new Ticket();
            t1.print(e);
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            ticketInfo = new TicketInformationManager();

            ticketInfo.GetBookingByID(Convert.ToInt32(comboBox2.Text), label38, label35, label37, label36, label41, label39, label40, label42);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ticketInfo = new TicketInformationManager();
            ticketInfo.DeleteTicket(Convert.ToInt32(comboBox2.Text));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
