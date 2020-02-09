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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }

        private void strAttBtn_Click(object sender, EventArgs e)
        {
            FingerprintAttendance form = new FingerprintAttendance();
            form.Owner = this;
            form.Show();
        }

        private void mngStaffBtn_Click(object sender, EventArgs e)
        {
            StaffManagement form = new StaffManagement();
            form.Owner = this;
            form.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
        }

        private void atdLogBtn_Click(object sender, EventArgs e)
        {
            AttendanceLog form = new AttendanceLog();
            form.Owner = this;
            form.Show(); 
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
