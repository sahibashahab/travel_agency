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
    public partial class ManagingEmployee : Form
    {
        EmployeeInformationManager Eim;
        string type;
        public ManagingEmployee()
        {
            InitializeComponent();
        }
        public ManagingEmployee(string a)
        {
            type = a;
            InitializeComponent();
        }

        private void Create_Emp_Click(object sender, EventArgs e)
        {
            try {
                int ProductIndex = comboBox4.SelectedIndex;
                ProductIndex=ProductIndex+4;
                Eim.CreateEmployee(txt_Ename.Text, txt_eadd.Text, txt_ECnic.Text, txt_EphNo.Text, txt_Eemail.Text, txt_EmpSalery.Text, textBox1.Text, ProductIndex, System.DateTime.Now.ToShortDateString());

                txt_Ename.Clear();
                txt_eadd.Clear();
                txt_ECnic.Clear();
                txt_EphNo.Clear();
                txt_Eemail.Clear();
                txt_EmpSalery.Clear();
                textBox1.Clear();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void ManagingEmployee_Load(object sender, EventArgs e)
        {
            Eim = new EmployeeInformationManager();
            Eim.GetRole(comboBox4);
            
            
           

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_EmpU_Click(object sender, EventArgs e)
        {
            try {
                int ProductIndex = comboBox5.SelectedIndex;
                ProductIndex++;
                Eim.UpdateEmployee(Convert.ToInt32(comboBox1.Text), txt_EnameU.Text, txt_eaddU.Text, txt_CnicU.Text, txt_PhnoU.Text, txt_EmailU.Text, textBox2.Text, ProductIndex);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }

        }

        

        private void btn_DelEmp_Click(object sender, EventArgs e)
        {
            try {
                Eim = new EmployeeInformationManager();
                Eim.DeleteEmployee(Convert.ToInt32(comboBox2.Text));
                textBox13.Clear();
                textBox15.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox3.Clear();
                textBox11.Clear();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            Eim.showAll(dataGridView1);
        }

        private void btn_ShowId_Click(object sender, EventArgs e)
        {
            try {
                Eim.showByID(dataGridView1, Convert.ToInt32(comboBox3.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }        

        private void tabControl1_Click(object sender, EventArgs e)
        {
           Eim = new EmployeeInformationManager();

            Eim.GetIDForEmployee(comboBox1);
            comboBox2.Items.Clear();
            Eim.GetIDForEmployee(comboBox2);
            comboBox3.Items.Clear();
            Eim.GetIDForEmployee(comboBox3);
         
            //comboBox2.Items.Clear();


        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (type=="Owner")
            {
                OwnerWindow ow= new OwnerWindow();
                ow.Show();
                this.Hide();
            }
            else
            {
                AdminWindow obj = new AdminWindow();
                obj.Show();
                this.Hide();
            }
            
        }

        private void SearchUpdate_Click(object sender, EventArgs e)
        {
            try {
                Eim.GetEmpByID(Convert.ToInt32(comboBox1.Text), txt_EnameU, txt_eaddU, txt_CnicU, txt_PhnoU, txt_EmailU, textBox2, comboBox5);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void SearchForDeletion_Click(object sender, EventArgs e)
        {
            try {
                Eim.GetEmpByID(Convert.ToInt32(comboBox2.Text), textBox13, textBox15, textBox12, textBox14, textBox3, textBox11, comboBox5);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            Eim = new EmployeeInformationManager();
            Eim.GetRole(comboBox5);
        }
    }
}
