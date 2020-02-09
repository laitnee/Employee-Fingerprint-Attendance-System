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
    public partial class AttendanceLog : Form
    {
        public AttendanceLog()
        {
            InitializeComponent();
            loadLog();
        }

       
        private void AttendanceLog_Load(object sender, EventArgs e)
        {

        }

        private void dtPckFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadLog()
        {
            using (ModelContext db = new ModelContext())
            {
                attendanceLogViewModelBindingSource4.DataSource = db.AttendanceRegisterList.Select(log => new AttendanceLogViewModel
                {
                    StaffFName = log.Staff.Firstname,
                    StaffLName = log.Staff.Lastname,
                    StaffMName = log.Staff.Middlename,
                    OnLeave = log.Staff.OnLeave,
                    Date = log.Date,
                    ArrivalTime = log.ArrivalTime,
                    DepartureTime = log.DepartureTime,
                    Remark = log.Remark
                }).ToList();
            }
            dataGridView1.ClearSelection();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                attendanceLogViewModelBindingSource4.DataSource = db.AttendanceRegisterList.Select(log => new AttendanceLogViewModel
                {
                    StaffFName = log.Staff.Firstname,
                    StaffLName = log.Staff.Lastname,
                    StaffMName = log.Staff.Middlename,
                    OnLeave = log.Staff.OnLeave,
                    Date = log.Date,
                    ArrivalTime = log.ArrivalTime,
                    DepartureTime = log.DepartureTime,
                    Remark = log.Remark
                }).Where(
                log => log.StaffFName.Contains(empSearchTxt.Text) ||
                           log.StaffLName.Contains(empSearchTxt.Text) ||
                             log.StaffMName.Contains(empSearchTxt.Text)
                  ).ToList();
            }

            dataGridView1.ClearSelection();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                attendanceLogViewModelBindingSource4.DataSource = db.AttendanceRegisterList.Select(log => new AttendanceLogViewModel
                {
                    StaffFName = log.Staff.Firstname,
                    StaffLName = log.Staff.Lastname,
                    StaffMName = log.Staff.Middlename,
                    OnLeave = log.Staff.OnLeave,
                    Date = log.Date,
                    ArrivalTime = log.ArrivalTime,
                    DepartureTime = log.DepartureTime,
                    Remark = log.Remark
                }).Where(
                    log => log.Date >= dtPckFrom.Value && log.Date <= dtPckTo.Value
                    ).ToList();
            }
            dataGridView1.ClearSelection();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            loadLog();
        }
    }
}
