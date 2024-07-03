using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TravelAgencySystem
{
    class Employee
    {
        string Ename { get; set; }
        string Eaddress { get; set; }
        int EID { get; set; }
        string ECnic { get; set; }
        string PhNo { get; set; }
        string Eemail { get; set; }
        string ESalery { get; set; }
        string password { get; set; }
        int role;
        string date;


        public Employee()
        {

        }

        public Employee(string a, string b, string c, string d, string e, string f, string g, int role, string date)
        {
            Ename = a;
            Eaddress = b;
            ECnic = c;
            PhNo = d;
            Eemail = e;
            ESalery = f;
            password = g;
            this.role = role;
            this.date = date;
        }
        public Employee(int id, string b, string c, string d, string e, string f, string g, int h)
        {
            EID = id;
            Ename = b;
            Eaddress = c;
            ECnic = d;
            PhNo = e;
            Eemail = f;
            ESalery = g;
            role = h;
        }


        
        public void UpdateEmployee()
        {
            SqlCommand cmd = new SqlCommand("UpdateData", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName",Ename );
            cmd.Parameters.AddWithValue("@EmpAddress", Eaddress);
            cmd.Parameters.AddWithValue("@EmpCnic", ECnic);
            cmd.Parameters.AddWithValue("@EmpPhNo", PhNo);
            cmd.Parameters.AddWithValue("@EmpEmail", Eemail);
            cmd.Parameters.AddWithValue("@EmpSalery", ESalery);
            cmd.Parameters.AddWithValue("@EmpRole", role);
            cmd.Parameters.AddWithValue("@ID", EID);

            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
        }
        public void DeleteEmp(int a)
        {
            EID = a;
            SqlCommand cmd = new SqlCommand("DeleteEmp", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", EID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
        }
        public void CreateEmployee()
        {
            
                SqlCommand cmd = new SqlCommand("CreateEmp", Connection.GetCon());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpName", Ename);
                cmd.Parameters.AddWithValue("@EmpAddress", Eaddress);
                cmd.Parameters.AddWithValue("@EmpCnic", ECnic);
                cmd.Parameters.AddWithValue("@EmpPhNo", PhNo);
                cmd.Parameters.AddWithValue("@EmpEmail", Eemail);
                cmd.Parameters.AddWithValue("@EmpSalery", ESalery);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@RoleID", role);
                cmd.Parameters.AddWithValue("@Date", date);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted");

        }













        

    }
}
