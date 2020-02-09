using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintAttendanceSystem
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            if(usernameTxt.Text == "admin" && pwdTxt.Text == "admin")
            {
                errorLbl.Text = "Loading...";
                Homepage form = new Homepage();
                form.Owner = this;
                form.Show();
                this.Visible = false;
            }
            else
            {
                errorLbl.Visible = true;
            }
        }
    }
}
