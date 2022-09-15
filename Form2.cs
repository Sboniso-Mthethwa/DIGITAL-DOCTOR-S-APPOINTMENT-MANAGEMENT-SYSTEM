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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {  //this methods allow to close a window when opening a new one
            frmLogin f1 = new frmLogin(); //instance of form1 which is Login
            f1.Show();
            this.Hide();
        }
    }
}
