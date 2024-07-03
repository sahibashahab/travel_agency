using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelAgencySystem
{
    public  class Connection
    {
        protected Connection()
        {

        }
        static SqlConnection con = new SqlConnection(@"D:\summer\dp\project\Dp project- Travel Agency System\Dp project\script.sql=True");
        public static SqlConnection GetCon()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
          
            return con;
        }
    }
}
