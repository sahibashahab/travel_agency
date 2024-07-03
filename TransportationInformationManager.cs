using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class TransportationInformationManager
    {

      

        //SelectingFromDatabase
        //forAirplane

        public void SelectAirplane(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectAirplane", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                box.Items.Add(sdr[0].ToString());
                
            }
            Connection.GetCon().Close();
        }
        public void GetPlaneID(ComboBox box)
        {
            
            SqlCommand cmd = new SqlCommand("SelectAirplane", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                box.Items.Add(sdr[1].ToString());
            }
            Connection.GetCon().Close();

        }
        public void GetLocation(ComboBox box)
        {
            
            SqlCommand cmd = new SqlCommand("select * from Loc", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();
            box.Items.Clear();
            while (sdr.Read())
            {
                box.Items.Add(sdr[1].ToString());
            }
            Connection.GetCon().Close();

        }
        public void GetAirByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g,TextBox h,TextBox i,TextBox j)
        {
            
            SqlCommand cmd = new SqlCommand("GetAirByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                g.Text = read["airplane_id"].ToString();
                b.Text = read["name"].ToString();
                c.Text = read["luxury_quota"].ToString();
                d.Text = read["economy_quota"].ToString();
                e.Text = read["bussiness_quota"].ToString();
                f.Text = read["company"].ToString();
                h.Text = read["Lprice"].ToString();
                i.Text = read["Bprice"].ToString();
                j.Text = read["Eprice"].ToString();
                
            }
            Connection.GetCon().Close();

        }
        public void GetRouteSelection(int a, DateTimePicker b, DateTimePicker c, ComboBox d, ComboBox e)
        {

            SqlCommand cmd = new SqlCommand("GetRouteSelection", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Text = read["DepartDate"].ToString();
                c.Text = read["DepartTime"].ToString();
                d.Text = read["CurrentLoc"].ToString();
                
                e.Text = read["DestinationLoc"].ToString();

            }
            Connection.GetCon().Close();
        }
        public void GetRouteID(ComboBox b)
        {


            SqlCommand cmd = new SqlCommand("GetRouteID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Items.Add(read[0].ToString());
               
            }
            Connection.GetCon().Close();

        }
        //ForAirplane
        //forTrain

        public void SelTrain(ComboBox box)
        {
            
            SqlCommand cmd = new SqlCommand("SelectTrain", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                box.Items.Add(sdr[0].ToString());
            }
            Connection.GetCon().Close();
        }
        public void GetTrainID(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectTrain", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                box.Items.Add(sdr[1].ToString());
            }
            Connection.GetCon().Close();

        }
        
        public void GetTrainByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, TextBox h, TextBox i, TextBox j)
        {

            SqlCommand cmd = new SqlCommand("GetTrainByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Text = read["TrainID"].ToString();
                c.Text = read["name"].ToString();
                d.Text = read["TLQ"].ToString();
                e.Text = read["TEQ"].ToString();
                f.Text = read["TBQ"].ToString();
                g.Text = read["company"].ToString();
                h.Text = read["Lprice"].ToString();
                i.Text = read["Bprice"].ToString();
                j.Text = read["Eprice"].ToString();

            }
            Connection.GetCon().Close();

        }


        //ForTrain
        //forBuss

        public void SelBus(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectBus", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                box.Items.Add(sdr[0].ToString());
            }
            Connection.GetCon().Close();
        }
        public void GetBusID(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectBus", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                box.Items.Add(sdr[1].ToString());
            }
            Connection.GetCon().Close();

        }

        public void GetBusByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, TextBox h, TextBox i, TextBox j)
        {

            SqlCommand cmd = new SqlCommand("GetBusByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Text = read["BusID"].ToString();
                c.Text = read["name"].ToString();
                d.Text = read["TLQ"].ToString();
                e.Text = read["TEQ"].ToString();
                f.Text = read["TBQ"].ToString();
                g.Text = read["company"].ToString();
                h.Text = read["Lprice"].ToString();
                i.Text = read["Bprice"].ToString();
                j.Text = read["Eprice"].ToString();

            }
            Connection.GetCon().Close();

        }
        public void ShowAllAir(DataGridView dgv)
        {
            Airplane a = new Airplane();
            a.showAll(dgv);
           
        }
        public void ShowAllTrain(DataGridView dgv)
        {
            Train b = new Train();
            b.showAll(dgv);
            
        }
        public void ShowAllBus(DataGridView dgv)
        {
            Buss c = new Buss();
            c.showAll(dgv);

        }

        public void ShowByIDAir(DataGridView dgv ,int Id)
        {
            Airplane a = new Airplane();
            a.showByID(dgv,Id);
            
        }
        public void ShowByIDTrain(DataGridView dgv, int Id)
            {
              Train b = new Train();
             b.showByID(dgv,Id);
          
            }

        public void ShowByIdBus(DataGridView dgv, int Id)
        {
            Buss c = new Buss();
            c.showByID(dgv, Id);
        }


        //ForBuss
        //SelectingFromDatabase

        
    }
}
