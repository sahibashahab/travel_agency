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
    public partial class SearchTicketAvailibility : Form
    {
        string Type;
        public SearchTicketAvailibility()
        {
            InitializeComponent();
        }
        public SearchTicketAvailibility(string a)
        {
            Type = a;
            InitializeComponent();
        }

        private void cb_CurrentLoc_DropDown(object sender, EventArgs e)
        {
            TransportationInformationManager tim = new TransportationInformationManager();
            tim.GetLocation(cb_CurrentLoc);
        }

        private void cb_Destination_DropDown(object sender, EventArgs e)
        {
            TransportationInformationManager tim = new TransportationInformationManager();
            tim.GetLocation(cb_Destination);
        }

        private void cb_ClassType_DropDown(object sender, EventArgs e)
        {
            cb_ClassType.Items.Clear();
            cb_ClassType.Items.Add("Luxury");
            cb_ClassType.Items.Add("Bussiness");
            cb_ClassType.Items.Add("Economy");
        }

        private void cb_TransType_DropDown(object sender, EventArgs e)
        {
            cb_TransType.Items.Clear();
            cb_TransType.Items.Add("Airplane");
            cb_TransType.Items.Add("Train");
            cb_TransType.Items.Add("Bus");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try {
                string departureDate = DepartDatePick.Text;
                string currentLocation = cb_CurrentLoc.Text;
                string destination = cb_Destination.Text;
                string transportType = cb_TransType.Text;
                string classType = cb_ClassType.Text;
                string noOfSeats = txt_NoSeats.Text;

                SearchAvailibilityManager sam = new SearchAvailibilityManager();
                sam.passSearch(departureDate, currentLocation, destination, transportType, classType, noOfSeats, dataGridView1);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
               
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.CurrentRow;
                string routeID = dataGridView1[0, row.Index].Value.ToString();
                if (routeID == null || routeID == "") {
                    MessageBox.Show("Please Enter Correct Values");
                    return;
                }
                MaintainBooking bt = new MaintainBooking(routeID, txt_NoSeats.Text, cb_ClassType.Text,Type);
                this.Hide();
                bt.Show(); }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }

        }
    }
}
