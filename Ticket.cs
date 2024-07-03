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
    class Ticket : AbstractTicket
    {
        int TicketID;
        int CustomerID;
        string BookedDate;
        string RouteID;
        int Seat;
        string  ClassType;
        static string type;
        


        public Ticket()
        {

        }
        

        public Ticket(int a, string b, string c, int d, string e)
        {
            CustomerID = a;
            BookedDate = b;
            RouteID = c;
            Seat =d;
            ClassType = e;
        }


        public void BookTicket()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BookTicket", Connection.GetCon());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", CustomerID);
                cmd.Parameters.AddWithValue("@route_id", RouteID);
                cmd.Parameters.AddWithValue("@no_of_seats", Seat);
                cmd.Parameters.AddWithValue("@class_type", ClassType);
                cmd.Parameters.AddWithValue("@BookedDate", BookedDate);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");
            }
            catch (Exception e) {
                MessageBox.Show("Record Has Been Inserted Already");
            }
        }
        public void DeleteTicket(int a)
        {
            TicketID = a;
            SqlCommand cmd = new SqlCommand("DeleteTicket", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID", TicketID);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            Connection.GetCon().Close();
        }
        public void Empa(string a)
        {
            type = a;
        }
      


        public void print(PrintPageEventArgs e)
        {
            
            Connection.GetCon().Close();
                                                                                         
            Font fo = new Font("Aerial", 16, FontStyle.Regular);
            Font f1 = new Font("Aerial", 20, FontStyle.Bold);

            SqlCommand cmd = new SqlCommand("GetPrintData", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader read = cmd.ExecuteReader();
          
            e.Graphics.DrawString("Bill type                :  " + type, f1, Brushes.Black, new PointF(240, 140));

            while (read.Read())
            {
                e.Graphics.DrawString("Customer Name        :   " + read["CustName"].ToString(), fo, Brushes.Blue, new PointF(140, 260));
                e.Graphics.DrawString("Departure Time       :   " + read["DepartTime"].ToString() , fo, Brushes.Blue, new PointF(140, 290));
                e.Graphics.DrawString("Departure Date       :   " + read["DepartDate"].ToString(), fo, Brushes.Blue, new PointF(140, 320));
                e.Graphics.DrawString("Current Location     :   " + read["CurrentLoc"].ToString(), fo, Brushes.Blue, new PointF(140, 350));
                e.Graphics.DrawString("Destination Location :   " + read["DestinationLoc"].ToString(), fo, Brushes.Blue, new PointF(140, 380));
                e.Graphics.DrawString("Class Type           :   " + read["class_type"].ToString(), fo, Brushes.Blue, new PointF(140, 410));
                e.Graphics.DrawString("No Of Seats          :   " + read["no_of_seats"].ToString(), fo, Brushes.Blue, new PointF(140, 440));
                e.Graphics.DrawString("Total Price          :   " + read["totalPrice"].ToString(), fo, Brushes.Blue, new PointF(140, 470));
            }
        }

        public override Ticket cloneTicket()
        {
            return (Ticket)this.MemberwiseClone();
            throw new NotImplementedException();
        }
    }

    }

