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
    public partial class MaintainAirplanes : Form
    {
        Airplane obj;
        Transport j;
        TransportFactory factory = new TransportFactory();
        public MaintainAirplanes()
        {
            InitializeComponent();
        }

      

        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
             obj=new Airplane();
             obj.SelectAirplane(comboBox1);
        }
        

       

        private void label17_Click(object sender, EventArgs e)
        {

        }

      

      

        private void MaintainAirplanes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
        
            comboBox2.Items.Clear();
            obj = new Airplane();
            
            obj.SelectAirplane(comboBox2);
        
    }

       

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            obj = new Airplane();
            obj.SelectAirplane(comboBox3);


        }

       

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

      

        private void label7_Click(object sender, EventArgs e)
        {
            TransportationSelection ts = new TransportationSelection();
            ts.Show();
            this.Hide();
        }

        private void btn_confrm_Click(object sender, EventArgs e)
        {
            try {
                
                obj = new Airplane(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(Lprice.Text), Convert.ToInt32(Bprice.Text), Convert.ToInt32(Eprice.Text));
                obj.createTransportInfo();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
            

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try {
                obj = new Airplane();
              
                obj.GetAirByID(Convert.ToInt32(comboBox1.Text), textBox11, textBox10, textBox9, textBox8, textBox7, textBox12, LpriceU, BpriceU, EpriceU);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try {
                obj = new Airplane(int.Parse(comboBox1.Text), textBox12.Text, textBox11.Text, Convert.ToInt16(textBox10.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox8.Text), textBox7.Text, Convert.ToInt32(LpriceU.Text), Convert.ToInt32(BpriceU.Text), Convert.ToInt32(EpriceU.Text));
                obj.UpdateTransportInfo();
                MessageBox.Show("Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                obj = new Airplane();
                obj.GetAirByID(Convert.ToInt32(comboBox2.Text), textBox13, textBox17, textBox18, textBox16, textBox15, textBox14, LpriceU, BpriceU, EpriceU);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try {
                j = factory.getTransport("Airplane");
                
                j.DeleteTransportInfo(int.Parse(comboBox2.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowByID_Click(object sender, EventArgs e)
        {
            try {
                obj = new Airplane();
                
                obj.showByID(dataGridView1, int.Parse(comboBox3.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            obj = new Airplane();
            obj.showAll(dataGridView1);
        }

        private void AirplaneRoute_Click(object sender, EventArgs e)
        {
            Routes ar = new Routes("Airplane");
            ar.Show();
            this.Hide();
        }
    }
}
