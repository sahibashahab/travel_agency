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
    public partial class mainTainTrain : Form
    {
        Train obj;
        TransportFactory factory = new TransportFactory();
        public mainTainTrain()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try {
                obj = new Train(txt_TrainID.Text, txt_Tname.Text, Convert.ToInt32(txt_TLQ.Text), Convert.ToInt32(txt_TBQ.Text), Convert.ToInt32(txt_TEQ.Text), txt_TCompany.Text, Convert.ToInt32(Lprice.Text), Convert.ToInt32(Bprice.Text), Convert.ToInt32(Eprice.Text));
                obj.createTransportInfo();
                MessageBox.Show("Inserted");
                
            }
            catch (Exception ea) {
                MessageBox.Show("Please Enter Correct Values");
            }
            

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try {
                obj = new Train();
                
                obj.GetTrainByID(int.Parse(combo_Selid.Text), txt_TID, txt_TnameU, txt_TLQU, txt_TBQU, txt_TEQU, txt_TcompanyU, LpriceUn, BpriceUn, EpriceUn);
            }            
             catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void combo_Selid_DropDown(object sender, EventArgs e)
        {
            combo_Selid.Items.Clear();
            obj = new Train();
            obj.SelTrain(combo_Selid);
            
        }

        private void combo_Selid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitU_Click(object sender, EventArgs e)
        {try {
                obj = new Train(int.Parse(combo_Selid.Text), txt_TID.Text, txt_TnameU.Text, Convert.ToInt16(txt_TLQU.Text), Convert.ToInt16(txt_TBQU.Text), Convert.ToInt16(txt_TEQU.Text), txt_TcompanyU.Text, Convert.ToInt32(LpriceUn.Text), Convert.ToInt32(BpriceUn.Text), Convert.ToInt32(EpriceUn.Text));
                obj.UpdateTransportInfo();
                MessageBox.Show("updated");
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }

        }

      

       

        private void combo_SelDel_DropDown(object sender, EventArgs e)
        {
            combo_SelDel.Items.Clear();
            obj = new Train();
            
            obj.SelTrain(combo_SelDel);
        }

        private void combo_SiD_DropDown(object sender, EventArgs e)
        {
            combo_SiD.Items.Clear();
            obj = new Train();
            obj.SelTrain(combo_SiD);

        }

      

    
     

        private void label7_Click(object sender, EventArgs e)
        {
            TransportationSelection ts = new TransportationSelection();
            ts.Show();
            this.Hide();
        }

        private void SearchDelete_Click(object sender, EventArgs e)
        {
            try {
                obj = new Train();
                obj.GetTrainByID(Convert.ToInt32(combo_SelDel.Text), textBox13, textBox18, textBox17, textBox16, textBox15, textBox14, LpriceUn, BpriceUn, Eprice);
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try {
                Transport t = factory.getTransport("Train");
                
                t.DeleteTransportInfo(int.Parse(combo_SelDel.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowByID_Click(object sender, EventArgs e)
        {
            try {
                obj = new Train();
                obj.showByID(dataGridView1, int.Parse(combo_SiD.Text));
            }
            catch (Exception ea)
            {
                MessageBox.Show("Please Enter Correct Values");
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            obj = new Train();
            obj.showAll(dataGridView1);
        }

        private void TrainRoutes_Click(object sender, EventArgs e)
        {
            Routes obj = new Routes("Train");
            obj.Show();
            this.Hide();
        }

        private void mainTainTrain_Load(object sender, EventArgs e)
        {

        }
    }
}
