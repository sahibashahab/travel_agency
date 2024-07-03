using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class Search
    {
        string departureDate;
        string currentLocation;
        string destination;
        string transportType;
        string classType;
        int noOfSeats;

        public Search(string depDate, string currLoc, string dest, string trantype, string clastype, string nos) {
            departureDate = depDate;
            currentLocation = currLoc;
            destination = dest;
            transportType = trantype;
            classType = clastype;
            noOfSeats = Convert.ToInt32( nos);
        }

        public void searchForRoute(DataGridView dg) {

            Connection.GetCon().Close();
            SqlCommand cmd = new SqlCommand("SearchRoute", Connection.GetCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@departureDate", departureDate);
            cmd.Parameters.AddWithValue("@currentLocation", currentLocation);
            cmd.Parameters.AddWithValue("@destinationLocation", destination);
            cmd.Parameters.AddWithValue("@transportID", transportType);
            cmd.Parameters.AddWithValue("@classType", classType);
            cmd.Parameters.AddWithValue("@noOfSeats", noOfSeats);


            SqlDataReader read = cmd.ExecuteReader();
            SqlDataReader sqlDataReader = read;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Route ID");
            dataTable.Columns.Add("Departure Date");
            dataTable.Columns.Add("Departure Time");
            dataTable.Columns.Add("Current Location");
            dataTable.Columns.Add("Destination Location");
            dataTable.Columns.Add("Transport ID");
            dataTable.Columns.Add("Remaining Seat");
            dataTable.Columns.Add("Booked Seats");
            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Route ID"] = sqlDataReader["id"];
                row["Departure Date"] = sqlDataReader["DepartDate"];
                row["Departure Time"] = sqlDataReader["DepartTime"];
                row["Current Location"] = sqlDataReader["CurrentLoc"];
                row["Destination Location"] = sqlDataReader["DestinationLoc"];
                row["Transport ID"] = sqlDataReader["transportID"];
                row["Remaining Seat"] = sqlDataReader["remaining"];
                row["Booked Seats"] = sqlDataReader["bookedSeats"];
                dataTable.Rows.Add(row);
            }
            dg.DataSource = dataTable;
            dg.DataBindings.ToString();
            //return reader;

            Connection.GetCon().Close();
        }
    }
}
