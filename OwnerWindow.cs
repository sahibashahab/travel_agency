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
    public partial class OwnerWindow : Form,LoginPart
    {
        Facadepatt fp = new Facadepatt();
        public OwnerWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fp.ManagingEmp();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fp.report();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OwnerWindow_Load(object sender, EventArgs e)
        {

        }

        public void Accept(AbstractVisitor ab)
        {
            ab.visit(this);
        }
    }
}
