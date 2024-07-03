using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace TravelAgencySystem
{
    class SearchAvailibilityManager
    {
        

        public void passSearch(string depDate,string currLoc,string dest,string trantype,string clastype,string nos,DataGridView dgv) {
            Search search = new Search(depDate, currLoc, dest, trantype, clastype, nos);
            search.searchForRoute(dgv);
        }
    }
}
