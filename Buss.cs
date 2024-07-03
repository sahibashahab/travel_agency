using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelAgencySystem
{
    class Buss:Transport
    {
        int Systemid;
        string id;
        string busName;
        int busBussinessQuota;
        int busLuxuryQuota;
        int busEconomyQuota;
        string busCompany;
        int Lprice;
        int Bprice;
        int Eprice;

        public Buss()
        {

        }
        public Buss(string busID, string busName, int busBussinessQuota, int busLuxuryQuota, int busEconomyQuota, string busCompany, int Lprice, int Bprice, int Eprice)
        {
            this.id = busID;
            this.busName = busName;
            this.busBussinessQuota = busBussinessQuota;
            this.busLuxuryQuota = busLuxuryQuota;
            this.busEconomyQuota = busEconomyQuota;
            this.busCompany = busCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }
        public Buss(int id, string busID, string busName, int busLuxuary, int busBussinessQuota, int busEconomyQuota, string busCompany, int Lprice, int Bprice, int Eprice)
        {
            Systemid = id;
            this.id = busID;
            this.busName = busName;
            this.busBussinessQuota = busBussinessQuota;
            busLuxuryQuota = busLuxuary;
            this.busEconomyQuota = busEconomyQuota;
            this.busCompany = busCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }

        public override string createTransportInfo()
        {


            SqlCommand cmd = new SqlCommand("CreateBus", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusID", id);
            cmd.Parameters.AddWithValue("@TLQ", busLuxuryQuota);
            cmd.Parameters.AddWithValue("@TEQ", busEconomyQuota);
            cmd.Parameters.AddWithValue("@TBQ", busBussinessQuota);
            cmd.Parameters.AddWithValue("@com", busCompany);
            cmd.Parameters.AddWithValue("@name", busName);
            cmd.Parameters.AddWithValue("@Lprice", Lprice);
            cmd.Parameters.AddWithValue("@Bprice", Bprice);
            cmd.Parameters.AddWithValue("@Eprice", Eprice);



            cmd.ExecuteNonQuery();
            Connection.GetCon().Close();
            return "Buss Inserted Successfully";
        }
        public override string UpdateTransportInfo()
        {
            SqlCommand cmd = new SqlCommand("UpdateBus", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusID", id);
            cmd.Parameters.AddWithValue("@TLQ", busLuxuryQuota);
            cmd.Parameters.AddWithValue("@TEQ", busEconomyQuota);
            cmd.Parameters.AddWithValue("@TBQ", busBussinessQuota);
            cmd.Parameters.AddWithValue("@com", busCompany);
            cmd.Parameters.AddWithValue("@name", busName);
            cmd.Parameters.AddWithValue("@id", Systemid);
            cmd.Parameters.AddWithValue("@Lprice", Lprice);
            cmd.Parameters.AddWithValue("@Bprice", Bprice);
            cmd.Parameters.AddWithValue("@Eprice", Eprice);
            cmd.ExecuteNonQuery();
            return "updated";

            Connection.GetCon().Close();
        }
        public void showAll(DataGridView dg)
        {
            string quree = "select * from bus ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void showByID(DataGridView dg, int id)
        {
            string quree = "select * from bus where  id =" + id;
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
            string quree = "select * from bus where id =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }

        public override void DeleteTransportInfo(int a)
        {
            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("DeleteBus", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deleted");
            Connection.GetCon().Close();
        }
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
        
        public void ShowAllBus(DataGridView dgv)
        {
            Buss c = new Buss();
            c.showAll(dgv);

        }

    }
}