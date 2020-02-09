using FingerprintAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAttendanceSystem
{
    class LogStaff
    {
        public LogStaff()
        {
        }

        public int LogAttendance(Staff _staff)
        {
            using (ModelContext db = new ModelContext())
            {
                var attendanceRegister = db.AttendanceRegisterList.Where(x =>
                    x.Staff.StaffId == _staff.StaffId && x.Date >= DateTime.Today).FirstOrDefault();
                //if not null update departure date
                if(attendanceRegister != null && attendanceRegister.DepartureTime == null)
                {
                        attendanceRegister.DepartureTime = DateTime.Now.ToShortTimeString();
                        if (db.Entry<AttendanceRegister>(attendanceRegister).State == System.Data.Entity.EntityState.Detached)
                            db.Set<AttendanceRegister>().Attach(attendanceRegister);
                        db.Entry<AttendanceRegister>(attendanceRegister).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    return 1;
                }
                //if null update
                if (attendanceRegister == null)
                {
                    attendanceRegister = new AttendanceRegister
                    {
                        Date = DateTime.Now,
                        ArrivalTime = DateTime.Now.ToShortTimeString(),
                        DepartureTime = null,
                        StaffId = _staff.StaffId,
                        Remark = "Present"
                    };
                    if (db.Entry<AttendanceRegister>(attendanceRegister).State == System.Data.Entity.EntityState.Detached)
                        db.Set<AttendanceRegister>().Attach(attendanceRegister);
                    db.Entry<AttendanceRegister>(attendanceRegister).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return 2;
                }
                return 0;
            }
        }

        public void stopAttendance()
        {
            using (ModelContext db = new ModelContext())
            {
                int[] attendanceRegisterid = db.AttendanceRegisterList.Where(x => x.Date >= DateTime.Today)
                                                                        .Select(x => x.StaffId ).ToArray();
                List<Staff> staffs = db.Staffs.ToList();
                int[] staffsId = staffs.Select(x => x.StaffId).ToArray();
                var missingStaff = staffsId.Except(attendanceRegisterid);
                foreach (var staffId in missingStaff)
                {
                    var attendanceRegister = new AttendanceRegister
                    {
                        Date = DateTime.Now,
                        ArrivalTime = "-",
                        DepartureTime = "-",
                        StaffId = staffId,
                        Remark = staffs.Where(x => x.StaffId == staffId).FirstOrDefault().OnLeave ? "on leave" 
                        : "absent"
                    };
                    if (db.Entry<AttendanceRegister>(attendanceRegister).State == System.Data.Entity.EntityState.Detached)
                        db.Set<AttendanceRegister>().Attach(attendanceRegister);
                    db.Entry<AttendanceRegister>(attendanceRegister).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }
        }

        public bool compareDate( DateTime date1, DateTime date2)
        {
            return date1.ToShortDateString()
                .Equals(date2.ToShortDateString(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
