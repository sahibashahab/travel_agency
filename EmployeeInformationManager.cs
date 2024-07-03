using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace TravelAgencySystem
{
    class EmployeeInformationManager
    {

        public void CreateEmployee(string a, string b, string c, string d, string e, string f, string g,int role,string date)
        {
            Employee emp = new Employee(a, b, c, d, e, f, g, role, date);
            emp.CreateEmployee();

        }
        public void UpdateEmployee(int id, string b, string c, string d, string e, string f, string g,int h)
        {
            Employee emp = new Employee(id, b, c, d, e, f, g, h);
            emp.UpdateEmployee();

        }
        public void DeleteEmployee(int a)
        {
            Employee e = new Employee();
            e.DeleteEmp(a);
        }

        public void GetEmpByID(int a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g,ComboBox h)
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
                g.Text = read["EmpSalery"].ToString();
                f.Text = read["EmpEmail"].ToString();
                h.Text = read["Role"].ToString();

            }
            Connection.GetCon().Close();
        }
        public void GetIDForEmployee(ComboBox box)
        {
           
            SqlCommand cmd = new SqlCommand("SelectEmp", Connection.GetCon());
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                box.Items.Add(sdr[0].ToString());
            }
            Connection.GetCon().Close();

        }
        public void GetRole(ComboBox b)
        {

            string quree = "select * from Role ";
            SqlCommand cmd = new SqlCommand(quree, Connection.GetCon());
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                b.Items.Add(read[1].ToString());
            }
            Connection.GetCon().Close();

        }




        public  void showAll(DataGridView dg)
        {
            string quree = "select * from Employee ";
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }
        public void showByID(DataGridView dg,int id)
        {
            string quree = "select * from Employee where EmpID =" +id;
            DataSet a = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(quree, Connection.GetCon());
            ada.Fill(a);
            dg.DataSource = a.Tables[0];

        }
    }
}