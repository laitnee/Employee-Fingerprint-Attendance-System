using FingerprintAttendanceSystem.Models;
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
    public partial class StaffManagement : Form
    {
        private DPFP.Template Template;

        public StaffManagement()
        {
            InitializeComponent();
            using (ModelContext db = new ModelContext())
            {
                staffBindingSource1.DataSource = db.Staffs.ToList();
            }
            dataGridView1.ClearSelection();

            splitContainer1.Panel2.Enabled = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff staff = staffBindingSource1.Current as Staff;

            if (staff.Fingerprint != null)
            {
                btnFingerPrint.Text = "Recapture Fingerprint";
            }
            if(staff.ImageUrl != null)
            {
                picImage.ImageLocation = staff.ImageUrl;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            splitContainer1.Panel2.Enabled = true;

            staffBindingSource1.Add(new Staff() { ObjectState = 1 });
            staffBindingSource1.MoveLast();
            dataGridView1.CurrentCell = dataGridView1.Rows[staffBindingSource1.Count - 1].Cells[0];
            txtbxFN.Focus();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Staff staff = staffBindingSource1.Current as Staff;
                Byte[] serFP = Template?.Bytes;
                if (Template != null) { Template.Serialize(ref serFP); staff.Fingerprint = serFP; };
            
                if (staff != null)
                {
                    if (db.Entry<Staff>(staff).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Staff>().Attach(staff);
                    if (staff.ObjectState == 1)
                        db.Entry<Staff>(staff).State = System.Data.Entity.EntityState.Added;
                    else if (staff.ObjectState == 2)
                        db.Entry<Staff>(staff).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    splitContainer1.Panel2.Enabled = false;
                    staff.ObjectState = 0;

                }
            }
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;
            txtbxFN.Focus();
            Staff Staff = staffBindingSource1.Current as Staff;
            if (Staff != null)
                Staff.ObjectState = 2;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = false;
            staffBindingSource1.ResetBindings(false);
            dataGridView1.ClearSelection();
        }
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to remove this thing",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Staff staff = staffBindingSource1.Current as Staff;
                    if (staff != null && ((int)dataGridView1.CurrentRow.Cells[0].Value != 0))
                    {
                        if (db.Entry<Staff>(staff).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Staff>().Attach(staff);
                        db.Entry<Staff>(staff).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        staffBindingSource1.RemoveCurrent();
                        splitContainer1.Panel2.Enabled = false;

                    }
                }
            }
        }

        private void OnTemplate(DPFP.Template template)
        {
                Template = template;
                if (Template != null)
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
          
        }


        private void btnFingerPrint_Click_1(object sender, EventArgs e)
        {
            EnrollmentForm form = new EnrollmentForm();
            form.OnTemplate += this.OnTemplate;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {  Filter = "JPEG|*.jpg" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                    Staff staff = staffBindingSource1.Current as Staff;
                    if (staff != null)
                        staff.ImageUrl = ofd.FileName;
                }
            }
        }
    }
}
