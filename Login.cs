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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginManager loginUser = new LoginManager();
            loginUser.controlLogin(usernameTxt.Text, passwordTxt.Text);
            this.Hide();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
