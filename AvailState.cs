using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class AvailState : AbstractState
    {
        public override void req()
        {
            SearchTicketAvailibility s = new SearchTicketAvailibility();
            
            s.Show();
        }
    }
}
