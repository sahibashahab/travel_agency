using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace TravelAgencySystem
{
    class TicketInformationManager
    {
        public void getValues(int routeID,Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Label lbl6)
        {
            SqlCommand cmd = new SqlCommand("GetAllValuesForBooking", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@routeID", routeID);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                lbl1.Text = read["DepartDate"].ToString();
                lbl2.Text = read["DepartTime"].ToString();
                lbl3.Text = read["CurrentLoc"].ToString();
                lbl4.Text = read["DestinationLoc"].ToString();
                lbl5.Text = read["transportID"].ToString();
                lbl6.Text = read["TransportType"].ToString();
            }
            Connection.GetCon().Close();
        }
      
        public void DeleteTicket(int a)
        {
            Ticket ticket = new Ticket();
            ticket.DeleteTicket(a);
        }

        public void BookID(ComboBox b)
        {
            SqlCommand cmd = new SqlCommand("GetBookID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Items.Add(read[0].ToString());

            }
            Connection.GetCon().Close();


        }
        public void GetBookingByID(int a, Label b, Label c, Label d, Label e, Label f, Label g, Label h, Label i)

        {

            SqlCommand cmd = new SqlCommand("GetBookingByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                g.Text = read["DepartDate"].ToString();
                b.Text = read["DepartTime"].ToString();
                c.Text = read["CurrentLoc"].ToString();
                d.Text = read["DestinationLoc"].ToString();
                e.Text = read["transportID"].ToString();
                f.Text = read["TransportType"].ToString();
                h.Text = read["class_type"].ToString();
                i.Text = read["no_of_seats"].ToString();
               

            }
            Connection.GetCon().Close();

        }
        public void GetPrint(PrintPageEventArgs e)
        {

           // Ticket ojb = new Ticket();

            //ojb.print(e);

        }
        
        
    }
}
