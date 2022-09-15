using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DIGITAL_DOCTOR_S_APPOINTMENT_MANAGEMENT_SYSTEM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create an instance for form2 which is Signup page
            frmSignup f2 = new frmSignup();

            f2.Show(); //shows the signUp page

            this.Hide(); //hide form1 which is login screen
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //exit button
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {//method of hide/show password char
            if (chkShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar =true ;
        }
    }
}
