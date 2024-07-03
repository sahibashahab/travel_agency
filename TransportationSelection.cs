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
    public partial class TransportationSelection : Form
    {
        public TransportationSelection()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            MaintainAirplanes ma = new MaintainAirplanes();
            ma.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            mainTainTrain obj = new mainTainTrain();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MaintainBus bus = new MaintainBus();
            this.Hide();
            bus.Show();

        }
    }
}
