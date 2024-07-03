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
    class ViewReport
    {

        string From;
        string Too;
        DataGridView Show;


        public ViewReport(string a,string b,DataGridView c)
        {
            From = a;
            Too = b;
            Show = c;

        }
        public void getSaleReport()
        {

            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("GetSaleData", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@From", From);
            cmd.Parameters.AddWithValue("@Too", Too);



            SqlDataReader read = cmd.ExecuteReader();
            SqlDataReader sqlDataReader = read;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Booking Date");
            dataTable.Columns.Add("Transport ID");
            dataTable.Columns.Add("Transport Type");
            dataTable.Columns.Add("Class Type");
            dataTable.Columns.Add("Number Of Seats");
            dataTable.Columns.Add("Total Price");
            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Booking Date"] = sqlDataReader["BookedDate"];
                row["Transport ID"] = sqlDataReader["transportID"];
                row["Transport Type"] = sqlDataReader["TransportType"];
                row["Class Type"] = sqlDataReader["class_type"];
                row["Number Of Seats"] = sqlDataReader["noOfSeats"];
                row["Total Price"] = sqlDataReader["TotalPrice"];
                dataTable.Rows.Add(row);
            }
            Show.DataSource = dataTable;
            Show.DataBindings.ToString();
            //return reader;

            Connection.GetCon().Close();
        }


        public void getEmployeeReport()
        {
            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("GetEmployeeData", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@From", From);
            cmd.Parameters.AddWithValue("@Too", Too);



            SqlDataReader read = cmd.ExecuteReader();
            SqlDataReader sqlDataReader = read;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Employee Name");
            dataTable.Columns.Add("Employee Salary");
            dataTable.Columns.Add("Employee Role");
            dataTable.Columns.Add("Joining Date");
            dataTable.Columns.Add("Number Of Seats Booked By This Employee");
        
            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Employee Name"] = sqlDataReader["EmpName"];
                row["Employee Salary"] = sqlDataReader["EmpSalery"];
                row["Employee Role"] = sqlDataReader["Role"];
                row["Joining Date"] = sqlDataReader["joiningDate"];
                row["Number Of Seats Booked By This Employee"] = sqlDataReader["numberOfSeatsBooked"];
               
                dataTable.Rows.Add(row);
            }
            Show.DataSource = dataTable;
            Show.DataBindings.ToString();
            //return reader;

            Connection.GetCon().Close();
        }



        public void getCustomerReport()
        {
            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("GetCustomerData", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@From", From);
            cmd.Parameters.AddWithValue("@To", Too);

            SqlDataReader read = cmd.ExecuteReader();
            SqlDataReader sqlDataReader = read;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Number Of Seats Booked");
            dataTable.Columns.Add("Booking Date");
            dataTable.Columns.Add("Transport Type");
            dataTable.Columns.Add("Class Type");
            dataTable.Columns.Add("Current Location");
            dataTable.Columns.Add("Destination Location");

            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Customer Name"] = sqlDataReader["CustName"];
                row["Number Of Seats Booked"] = sqlDataReader["numOfSeatsBooked"];
                row["Booking Date"] = sqlDataReader["BookedDate"];
                row["Transport Type"] = sqlDataReader["TransportType"];
                row["Class Type"] = sqlDataReader["class_type"];
                row["Current Location"] = sqlDataReader["CurrentLoc"];
                row["Destination Location"] = sqlDataReader["DestinationLoc"];

                dataTable.Rows.Add(row);
            }
            Show.DataSource = dataTable;
            Show.DataBindings.ToString();
            //return reader;

            Connection.GetCon().Close();
        }

    }


    }

