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
    class AirplaneBuilder : AbstractRouteBuilderr
    {
        public override void Back()
        {
            MaintainAirplanes ma = new MaintainAirplanes();
            ma.Show();
        }

        public override void Dropdown(ComboBox combo)
        {
            
            Airplane tim = new Airplane();
            combo.Items.Clear();
            tim.GetPlaneID(combo);
        }
    }
}
