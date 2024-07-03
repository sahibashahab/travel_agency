using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TravelAgencySystem
{
    class MaintainCustomerManager
    {
        public void CreateCustomer(string a, string b,string c,string d,string e,int f,string date)
        {
            Customer cust = new Customer(a, b, c, d, e, f, date);
           
            cust.CreateCustomer();

        }
        public void UpdateCustomer(int id, string b, string c, string d, string e, string f)
        {
            Customer cust = new Customer(id, b, c, d, e, f);
            cust.UpdateCustomerInfo();

        }
       public void DeleteCustomer(int id)
        {
            Customer Cust = new Customer();
            Cust.DeleteCustomer(id);

        }
        
        public void GetCustomerByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f)
        {
            SqlCommand cmd = new SqlCommand("GetCustByID", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                b.Text = read["CustName"].ToString();
                c.Text = read["CustAdd"].ToString();
                d.Text = read["CustCnic"].ToString();
                e.Text = read["CustPhNo"].ToString();
                f.Text = read["CustPPortNo"].ToString();
                

            }
            Connection.GetCon().Close();
        }



        public void showAll(DataGridView dg)
        {
            string quree = "select * from Customer ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }
        public void showByID(DataGridView dg, int id)
        {
            string quree = "select * from Customer where CustID =" + id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }
        public void SelectValueCombo(ComboBox box)
        {

            SqlCommand cmd = new SqlCommand("SelectCust", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                box.Items.Add(sdr[0].ToString());

            }
            Connection.GetCon().Close();




        }
    }
}
