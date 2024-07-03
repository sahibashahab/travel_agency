using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TravelAgencySystem
{
    class Airplane:Transport
    {
        int Systemid;
        string id;
        string airplaneName;
        int airplaneBussinessQuota;
        int airplaneLuxuryQuota;
        int airplaneEconomyQuota;
        string airplaneCompany;
        int Lprice;
        int Bprice;
        int Eprice;

        public Airplane()
        {

        }
        public Airplane(string airID,string airName,int airBussinessQuota,int airLuxuryQuota,int airEconomyQuota,string airCompany,int Lprice,int Bprice,int Eprice) {
           this.id = airID;
            airplaneName = airName;
            airplaneBussinessQuota = airBussinessQuota;
            airplaneLuxuryQuota = airLuxuryQuota;
            airplaneEconomyQuota = airEconomyQuota;
            airplaneCompany = airCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }
        public Airplane(int id, string airID, string airName, int airBussinessQuota, int airLuxuryQuota, int airEconomyQuota, string airCompany, int Lprice, int Bprice, int Eprice)
        {
            Systemid=id;
           this.id = airID;
            airplaneName = airName;
            airplaneBussinessQuota = airBussinessQuota;
            airplaneLuxuryQuota = airLuxuryQuota;
            airplaneEconomyQuota = airEconomyQuota;
            airplaneCompany = airCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }

        public override string createTransportInfo()
        {
            SqlCommand cmd = new SqlCommand("CreateAirplane", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@airplane_id", id);
            cmd.Parameters.AddWithValue("@luxury_quota", airplaneLuxuryQuota);
            cmd.Parameters.AddWithValue("@economy_quota", airplaneEconomyQuota);
            cmd.Parameters.AddWithValue("@bussiness_quota", airplaneBussinessQuota);
            cmd.Parameters.AddWithValue("@com", airplaneCompany);
            cmd.Parameters.AddWithValue("@name", airplaneName);
            cmd.Parameters.AddWithValue("@Lprice", Lprice);
            cmd.Parameters.AddWithValue("@Bprice", Bprice);
            cmd.Parameters.AddWithValue("@Eprice", Eprice);



            cmd.ExecuteNonQuery();
            Connection.GetCon().Close();
            return "Airplane Inserted Successfully";
        }
        
        public void showAll(DataGridView dg)
        {
            string quree = "select * from Airplane ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void showByID(DataGridView dg, int id)
        {
            string quree = "select * from Airplane where id =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void RouteshowAll(DataGridView dg)
        {
            string quree = "select * from Route ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void RouteshowByID(DataGridView dg, int id)
        {
            string quree = "select * from Route where id =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }

        public override void DeleteTransportInfo(int a)
        {
            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("DeleteAirplane", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deleted");
            Connection.GetCon().Close();
        }
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
        public void GetAirByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, TextBox h, TextBox i, TextBox j)
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

        public override string UpdateTransportInfo()
        {
            SqlCommand cmd = new SqlCommand("UpdateAirplane", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@airid", id);
            cmd.Parameters.AddWithValue("@luxquota", airplaneLuxuryQuota);
            cmd.Parameters.AddWithValue("@ecoquota", airplaneEconomyQuota);
            cmd.Parameters.AddWithValue("@busquota", airplaneBussinessQuota);
            cmd.Parameters.AddWithValue("@com", airplaneCompany);
            cmd.Parameters.AddWithValue("@name", airplaneName);
            cmd.Parameters.AddWithValue("@id", Systemid);
            cmd.Parameters.AddWithValue("@Lprice", Lprice);
            cmd.Parameters.AddWithValue("@Bprice", Bprice);
            cmd.Parameters.AddWithValue("@Eprice", Eprice);
            cmd.ExecuteNonQuery();
            return "updated";

            
        }

        

        
    }
}
