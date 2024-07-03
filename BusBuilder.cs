using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class BusBuilder : AbstractRouteBuilderr
    {
        public override void Back()
        {
            MaintainBus mt = new MaintainBus();
            mt.Show();
        }

        public override void Dropdown(ComboBox combo)
        {
            Buss tim = new Buss();
            combo.Items.Clear();
            tim.GetBusID(combo);
        }
    }
}
