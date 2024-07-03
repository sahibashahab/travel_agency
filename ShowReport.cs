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
    public partial class ShowReport : Form
    {
        public ShowReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewManager rvm = new ReportViewManager();
            rvm.getSaleReport(dateTimePicker1,dateTimePicker2,dataGridView1);
            

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            OwnerWindow obj = new OwnerWindow();
            obj.Show();
            this.Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ReportViewManager rvm = new ReportViewManager();
            rvm.getCustomerReport(dateTimePicker5, dateTimePicker6, dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportViewManager rvm = new ReportViewManager();
            rvm.getEmployeeReport(dateTimePicker3, dateTimePicker4, dataGridView2);
        }
    }
}
