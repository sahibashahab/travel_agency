using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class Admin
    {
        int ComboID;
        string Ename { get; set; }
        string Eaddress { get; set; }
        string EID { get; set; }
        string ECnic { get; set; }
        string PhNo { get; set; }
        string Eemail { get; set; }
        string ESalery { get; set; }
        int roleID;


        public void CreateAdmin()
        {
            SqlCommand cmd = new SqlCommand("UpdateEmpToAdmin", Connection.GetCon());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", Ename);
            cmd.Parameters.AddWithValue("@EmpAddress", Eaddress);
            cmd.Parameters.AddWithValue("@EmpCnic", ECnic);
            cmd.Parameters.AddWithValue("@EmpPhNo", PhNo);
            cmd.Parameters.AddWithValue("@EmpSalery", ESalery);
            cmd.Parameters.AddWithValue("@RoleID", roleID);

            cmd.Parameters.AddWithValue("@ID", ComboID);


            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
        }
        public void Create(int a, string b, string c, string d, string e, string f, int g)
        {
            ComboID = a;
            Ename = b;
            Eaddress = c;
            ECnic = d;
            PhNo = e;
            ESalery = f;
            roleID = g;
            


        }
    }
}
