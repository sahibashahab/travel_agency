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
    public partial class MaintainCustomer : Form
    {
        MaintainCustomerManager mcm;
        
        string type;
        int b;
        public MaintainCustomer( string a)
        {
            type = a;
            
            

            InitializeComponent();
        }
        public MaintainCustomer(string a,int b)
        {
            type = a;
            this.b = b;



            InitializeComponent();
        }
        public MaintainCustomer()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (type=="Admin")
            {
                AdminWindow obj = new AdminWindow();
                obj.Show();
                this.Hide();
            }
            else if(type=="Emp")
            {
                Employeewindow obj = new Employeewindow();
                obj.Show();
                this.Hide();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mcm = new MaintainCustomerManager();
            comboBox1.Items.Clear();
            mcm.SelectValueCombo(comboBox1);
            comboBox2.Items.Clear();
            mcm.SelectValueCombo(comboBox2);
            comboBox3.Items.Clear();
            mcm.SelectValueCombo(comboBox3);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }



        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MaintainCustomer_Load(object sender, EventArgs e)
        {

        }





        private void Create_Click(object sender, EventArgs e)
        {
            try {
                if (txt_CustName.Text == "" || txt_CustAdd.Text =="" || txt_CustCnic.Text=="" || txt_CustPhNo.Text == "" || txt_CustPPNo.Text == "" ) {
                    MessageBox.Show("Please Enter Some Values");
                    
                    return;
                }
                mcm = new MaintainCustomerManager();
                int Eid = Authentication.EId;
                mcm.CreateCustomer(txt_CustName.Text, txt_CustAdd.Text, txt_CustCnic.Text, txt_CustPhNo.Text, txt_CustPPNo.Text, Eid, System.DateTime.Now.ToShortDateString());
                txt_CustName.Clear();
                txt_CustAdd.Clear();
                txt_CustCnic.Clear();
                txt_CustPhNo.Clear();
                txt_CustPPNo.Clear();
                MessageBox.Show(b.ToString());
                if (b==1)
                {
                    SearchTicketAvailibility obj = new SearchTicketAvailibility();
                    obj.Show();
                    this.Hide();
                }
               
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }



        private void Update_Click(object sender, EventArgs e)
        {
            try {
                mcm.UpdateCustomer(Convert.ToInt32(comboBox1.Text), txt_CustNameU.Text, txt_CustAddU.Text, CustCnic.Text, CustPhno.Text, CustPpNo.Text);
                txt_CustNameU.Clear();
                txt_CustAddU.Clear();
                CustCnic.Clear();
                CustPhno.Clear();
                CustPpNo.Clear();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void SearchCustomerForUpdation_Click(object sender, EventArgs e)
        {
            try {
                mcm = new MaintainCustomerManager();
                mcm.GetCustomerByID(int.Parse(comboBox1.Text), txt_CustNameU, txt_CustAddU, CustCnic, CustPhno, CustPpNo);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void SearchCustomerForDeletetion_Click(object sender, EventArgs e)
        {
            try {
                mcm = new MaintainCustomerManager();
                mcm.GetCustomerByID(int.Parse(comboBox2.Text), textBox13, textBox15, textBox12, textBox14, textBox11);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try {
                mcm = new MaintainCustomerManager();
                mcm.DeleteCustomer(int.Parse(comboBox2.Text));
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowByID_Click(object sender, EventArgs e)
        {
            try {
                mcm = new MaintainCustomerManager();
                mcm.showByID(dataGridView1, int.Parse(comboBox3.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            mcm = new MaintainCustomerManager();
            mcm.showAll(dataGridView1);
        }
    }
}
