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
    class AdminManager
    {
        public void GetEmpByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f)
        {
            SqlCommand cmd = new SqlCommand("GetEmpByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Text = read["EmpName"].ToString();
                c.Text = read["EmpAddress"].ToString();
                d.Text = read["EmpCninc"].ToString();
                e.Text = read["EmpPhNo"].ToString();
                f.Text = read["EmpSalery"].ToString();
             

            }
            Connection.GetCon().Close();
        }
        public void Sel(ComboBox box)
        {
            
            SqlCommand cmd = new SqlCommand("SelectEmpForAdmin", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();
           
            while (sdr.Read())
            {
                box.Items.Add(sdr[0].ToString());
            }
            Connection.GetCon().Close();



        }
        public void Sel1(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectAdmin1", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                box.Items.Add(sdr[0].ToString());
            }
            Connection.GetCon().Close();



        }
        public void setAdminInfo(int a, string b, string c, string d, string e, string f,int g)
        {
            Admin ad = new Admin();
            ad.Create(a, b, c, d, e, f, g);
            ad.CreateAdmin();

        }
        public void UpdateAdminInfo(int a, string b, string c, string d, string e, string f, int g)
        {
            SqlCommand cmd = new SqlCommand("UpdateEmpToAdmin", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName",b);
            cmd.Parameters.AddWithValue("@EmpAddress",c );
            cmd.Parameters.AddWithValue("@EmpCnic", d);
            cmd.Parameters.AddWithValue("@EmpPhNo", e);
            cmd.Parameters.AddWithValue("@EmpSalery", f);
            cmd.Parameters.AddWithValue("@RoleID", g);

            cmd.Parameters.AddWithValue("@ID", a);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Done");
        }
        public void showAll(DataGridView dg)
        {
            string quree = "SelectAdmin1";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }
        public void showByID(DataGridView dg, int id)
        {
            string quree = "select * from Employee where EmpID =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }



    }
}
