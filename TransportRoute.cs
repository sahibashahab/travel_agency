using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class TransportRoute
    {
        int ID;
        string RouteID;
        string DDate;
        string Time;
        string Cloc;
        string Dloc;
        string type;


        public TransportRoute()
        {

        }

        public TransportRoute(string a, string b, string c, string d, string e, string transportType)
        {
            RouteID = a;
            DDate = b;
            Time = c;
            Cloc = d;
            Dloc = e;
            type = transportType;

        }
        public TransportRoute(int id, string a, string b, string c, string d)
        {
            ID = id;
            DDate = a;
            Time = b;
            Cloc = c;
            Dloc = d;
           

        }





        public void CreateRoute() {
            SqlCommand cmd = new SqlCommand("CreateRoute", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PlaneID", RouteID);
            cmd.Parameters.AddWithValue("@DDate", DDate);
            cmd.Parameters.AddWithValue("@Time", Time);
            cmd.Parameters.AddWithValue("@CLoc", Cloc);
            cmd.Parameters.AddWithValue("@Dloc", Dloc);
            cmd.Parameters.AddWithValue("@transportType", type);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            Connection.GetCon().Close();
        }
        public void UpdateRoute() {
            SqlCommand cmd = new SqlCommand("UpdateAirRoute", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RouteID", ID);
            cmd.Parameters.AddWithValue("@DDate", DDate);
            cmd.Parameters.AddWithValue("@Time", Time);
            cmd.Parameters.AddWithValue("@CLoc", Cloc);
            cmd.Parameters.AddWithValue("@Dloc", Dloc);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            Connection.GetCon().Close();
        }
        public void DeleteRoute(int a) {

            ID = a;
            SqlCommand cmd = new SqlCommand("DeleteAirRoute", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RouteID", a);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            Connection.GetCon().Close();
        }
    }
}
