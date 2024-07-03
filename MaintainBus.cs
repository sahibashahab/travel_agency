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
    public partial class MaintainBus : Form
    {
        Buss tip;
        TransportFactory factory = new TransportFactory();
        public MaintainBus()
        {
            InitializeComponent();
        }

           private void Sub_Click(object sender, EventArgs e)
        {
            try {
                tip = new Buss(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(Lprice.Text), Convert.ToInt32(Bprice.Text), Convert.ToInt32(Eprice.Text));
                tip.createTransportInfo();
                MessageBox.Show("Inserted");
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

     

        private void combo_Sel_DropDown(object sender, EventArgs e)
        {
            combo_Sel.Items.Clear();
            tip = new Buss();
            tip.SelBus(combo_Sel);
        }

      

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            tip = new Buss();
            tip.SelBus(comboBox2);
        }

       

        

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            tip = new Buss();
            tip.SelBus(comboBox3);

        }

     

      

        private void button1_Click(object sender, EventArgs e)
        {
            Routes r = new Routes("Bus");
            r.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            TransportationSelection ts = new TransportationSelection();
            ts.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SearchUpdate_Click(object sender, EventArgs e)
        {
            try {
                tip = new Buss();
                tip.GetBusByID(Convert.ToInt32(combo_Sel.Text), textBox12, textBox11, textBox10, textBox9, textBox8, textBox7, LpriceU, BpriceU, EpriceU);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void Submit_Update_Click(object sender, EventArgs e)
        {
            try {
                tip = new Buss(int.Parse(combo_Sel.Text), textBox12.Text, textBox11.Text, Convert.ToInt16(textBox10.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox8.Text), textBox7.Text, Convert.ToInt32(LpriceU.Text), Convert.ToInt32(BpriceU.Text), Convert.ToInt32(EpriceU.Text));
                tip.UpdateTransportInfo();
                MessageBox.Show("updated");
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void SearchDelete_Click(object sender, EventArgs e)
        {
            try {
                tip = new Buss();
               tip.GetBusByID (Convert.ToInt32(comboBox2.Text), textBox13, textBox18, textBox17, textBox16, textBox15, textBox14, LpriceU, BpriceU, EpriceU);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void Submit_Delete_Click(object sender, EventArgs e)
        {
            try {
                Transport t = factory.getTransport("Buss");
                t.DeleteTransportInfo(int.Parse(comboBox2.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowByID_Click(object sender, EventArgs e)
        {
            try {
                tip = new Buss();
                tip.showByID(dataGridView1, int.Parse(comboBox3.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            tip = new Buss();
            tip.showAll(dataGridView1);
        }

        private void MaintainBus_Load(object sender, EventArgs e)
        {

        }
    }
}
