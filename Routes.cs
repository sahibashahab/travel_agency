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
    public partial class Routes : Form
    {
        TransportationInformationManager tim;
        string Type;
        TransportRoute tr;
        public Routes(string a)
        {
            InitializeComponent();
            Type = a;

        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            if (Type == "Airplane")
            {
                AbstractRouteBuilderr obj = new AirplaneBuilder();
                obj.Dropdown(combo_PlaneID);
                
            }
            else if(Type=="Train")
            {
                AbstractRouteBuilderr obj = new TrainBuilder();
                obj.Dropdown(combo_PlaneID);


            }
            else if (Type == "Bus")
            {
                AbstractRouteBuilderr obj = new BusBuilder();
                obj.Dropdown(combo_PlaneID);



            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            combo_CLoc.Items.Clear();
            tim.GetLocation(combo_CLoc);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            combo_Dest.Items.Clear();
            tim.GetLocation(combo_Dest);
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_show.Items.Clear();
            tim.GetPlaneID(Combo_show);

        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_update.Items.Clear();
            tim.GetRouteID(Combo_update);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox6_DropDown(object sender, EventArgs e)
        {
 
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {



            tr = new TransportRoute(combo_PlaneID.Text, dateTimePicker1.Text, txt_Time.Text, combo_CLoc.Text, combo_Dest.Text, Type);
            tr.CreateRoute();
            


         
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            tim = new TransportationInformationManager();
     
            tim.GetRouteSelection(int.Parse(Combo_update.Text),dateTimePicker2, dateTimePicker4,Combo_clocU,Combo_DestU);
            
            Combo_clocU.Items.Clear();
            Combo_DestU.Items.Clear();



        }

        private void Submit_Click(object sender, EventArgs e)
        {

            tr = new TransportRoute(int.Parse(Combo_update.Text), dateTimePicker2.Text, dateTimePicker4.Text, Combo_clocU.Text, Combo_DestU.Text);
            tr.UpdateRoute();
           
        }

        private void Combo_clocU_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_clocU.Items.Clear();
            tim.GetLocation(Combo_clocU);
        }

        private void Combo_DestU_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_DestU.Items.Clear();
            tim.GetLocation(Combo_DestU);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Combo_del_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_del.Items.Clear();
            tim.GetRouteID(Combo_del);

        }

        private void Cloc_Del_DropDown(object sender, EventArgs e)
        {
           
        }

        private void Combo_DestDel_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_DestDel.Items.Clear();
            tim.GetLocation(Combo_DestDel);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tim = new TransportationInformationManager();

            tim.GetRouteSelection(int.Parse(Combo_del.Text), dateTimePicker3, dateTimePicker4, comboBox1, Combo_DestDel);


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tr = new TransportRoute();
            tr.DeleteRoute(int.Parse( Combo_del.Text));

        }

        private void Combo_show_DropDown(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            Combo_show.Items.Clear();
            tim.GetRouteID(Combo_show);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Airplane air = new Airplane();
            air.RouteshowByID(dataGridView1,int.Parse(Combo_show.Text));
           
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            
            
            
                Airplane air = new Airplane();
                air.RouteshowAll(dataGridView1);
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (Type == "Airplane")
            {
                AbstractRouteBuilderr obj = new AirplaneBuilder();
                obj.Back();
                this.Hide();

            }
            else if (Type == "Train")
            {
                AbstractRouteBuilderr obj = new TrainBuilder();
                obj.Back();
                this.Hide();


            }
            else if (Type == "Bus")
            {
                AbstractRouteBuilderr obj = new BusBuilder();
                obj.Back();
                this.Hide();



            }
        }

        private void Combo_update_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            tim = new TransportationInformationManager();
            comboBox1.Items.Clear();
            tim.GetLocation(comboBox1);
        }

        private void Routes_Load(object sender, EventArgs e)
        {

        }
    }
}
