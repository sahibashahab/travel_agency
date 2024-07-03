using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelAgencySystem
{
    class Authentication
    {
        string userName { get; set; }
        string userPassword { get; set; }
        string userRole { get; set; }
        public static int EId = 0;

        public Authentication()
        {

        }

        public Authentication(string username,string password) {
            userName = username;
            userPassword = password;
        }

        public string auth() {
            SqlCommand cmd = new SqlCommand("LoginProc", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName",userName);
            cmd.Parameters.AddWithValue("@UserPassword", userPassword);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                userRole = read["Role"].ToString();
                EId = int.Parse( read["EmpID"].ToString());

            }
            Connection.GetCon().Close();
            return userRole;
        }
        
    }
}
