using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelAgencySystem
{
    class Customer
    {
        string Custname { get; set; }
        string Custaddress { get; set; }
        int CustID { get; set; }
        string CustCnic { get; set; }
        string CustPhNo { get; set; }
        string CustPNo { get; set; }
        int EId;
        string date;
        


        public Customer(string a, string b, string c, string d, string e, int f, string date)
        {
            Custname = a;
            Custaddress = b;
            CustCnic = c;
            CustPhNo = d;
            CustPNo = e;
            EId = f;
            this.date = date;
            
        }

        public Customer(int id, string b, string c, string d, string e, string f)
        {
            CustID = id;
            Custname = b;
            Custaddress = c;
            CustCnic = d;
            CustPhNo = e;
            CustPNo = f;

        }
        public Customer()
        {

        }





        
        
       
        public void CreateCustomer()
        {
            SqlCommand cmd = new SqlCommand("CreateCust", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustName", Custname);
            cmd.Parameters.AddWithValue("@CustAdd", Custaddress);
            cmd.Parameters.AddWithValue("@CustCnic", CustCnic);
            cmd.Parameters.AddWithValue("@CustPhNo", CustPhNo);
            cmd.Parameters.AddWithValue("@CustPPortNo",CustPNo);
            cmd.Parameters.AddWithValue("@EmpID", EId);
            cmd.Parameters.AddWithValue("@Date", date);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted");

        }
        
        public void UpdateCustomerInfo()
        {
            SqlCommand cmd = new SqlCommand("UpdateCustData", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustName", Custname);
            cmd.Parameters.AddWithValue("@CustAdd", Custaddress);
            cmd.Parameters.AddWithValue("@CustCnic", CustCnic);
            cmd.Parameters.AddWithValue("@CustPhNo", CustPhNo);
            cmd.Parameters.AddWithValue("@CustPPortNo", CustPNo);
            cmd.Parameters.AddWithValue("@ID", CustID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
        }
        public void DeleteCustomer(int a)
        {
            CustID = a;
            SqlCommand cmd = new SqlCommand("DeleteCust", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", CustID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
        }



    }

    }

