using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySystem
{
    class TrainBuilder : AbstractRouteBuilderr
    {
        public override void Back()
        {
            mainTainTrain mt = new mainTainTrain();
            mt.Show();
        }

        public override void Dropdown(ComboBox combo)
        {
            Train tim = new Train();
            combo.Items.Clear();
            tim.GetTrainID(combo);
        }
    }
}
