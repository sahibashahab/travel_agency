using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class Train:Transport
    {
        int Systemid;
        string id;
        string TrainName;
        int TrainBussinessQuota;
        int TrainLuxuryQuota;
        int TrainEconomyQuota;
        string TrainCompany;
        int Lprice;
        int Bprice;
        int Eprice;

        public Train()
        {

        }
        public Train(string airID, string TrainName, int TrainBussinessQuota, int TrainLuxuryQuota, int TrainEconomyQuota, string TrainCompany, int Lprice, int Bprice, int Eprice)
        {
            this.id = airID;
           this. TrainName = TrainName;
            this.TrainBussinessQuota = TrainBussinessQuota;
            this.TrainLuxuryQuota = TrainLuxuryQuota;
            this.TrainEconomyQuota = TrainEconomyQuota;
            this.TrainCompany = TrainCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }
        public Train(int id, string TrainID, string TrainName, int LuxuaryQuota, int TrainBussinessQuota, int TrainEconomyQuota, string TrainCompany, int Lprice, int Bprice, int Eprice)
        {
            Systemid = id;
            this.id = TrainID;
            this.TrainName = TrainName;
            this.TrainBussinessQuota = TrainBussinessQuota;
            TrainLuxuryQuota = LuxuaryQuota;
            this.TrainEconomyQuota = TrainEconomyQuota;
            this.TrainCompany = TrainCompany;
            this.Lprice = Lprice;
            this.Bprice = Bprice;
            this.Eprice = Eprice;
        }

        public override string createTransportInfo()
        {
          

            SqlCommand cmd = new SqlCommand("CreateTrain", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainID", id);
            cmd.Parameters.AddWithValue("@TLQ", TrainLuxuryQuota);
            cmd.Parameters.AddWithValue("@TEQ", TrainEconomyQuota);
            cmd.Parameters.AddWithValue("@TBQ", TrainBussinessQuota);
            cmd.Parameters.AddWithValue("@com", TrainCompany);
            cmd.Parameters.AddWithValue("@name", TrainName);
            cmd.Parameters.AddWithValue("@Lprice", Lprice);
            cmd.Parameters.AddWithValue("@Bprice", Bprice);
            cmd.Parameters.AddWithValue("@Eprice", Eprice);



            cmd.ExecuteNonQuery();
            Connection.GetCon().Close();
            return "Train Inserted Successfully";
        }
        public override string UpdateTransportInfo()
        {
            SqlCommand cmd = new SqlCommand("UpdateTrain", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainID", id);
            cmd.Parameters.AddWithValue("@TLQ", TrainLuxuryQuota);
            cmd.Parameters.AddWithValue("@TEQ", TrainEconomyQuota);
            cmd.Parameters.AddWithValue("@TBQ", TrainBussinessQuota);
            cmd.Parameters.AddWithValue("@com", TrainCompany);
            cmd.Parameters.AddWithValue("@name", TrainName);
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
            string quree = "select * from Train ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void showByID(DataGridView dg, int id)
        {
            string quree = "select * from Train where  id =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void RouteshowAll(DataGridView dg)
        {
            string quree = "select * from Route";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }
        public void RouteshowByID(DataGridView dg, int id)
        {
            string quree = "select * from Train where id =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];
            Connection.GetCon().Close();

        }

        public override void DeleteTransportInfo(int a)
        {
            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("DeleteTrain", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deleted");
            Connection.GetCon().Close();
        }
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

    }
}
