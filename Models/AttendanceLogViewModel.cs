using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAttendanceSystem.Models
{
    class AttendanceLogViewModel
    {
        public DateTime Date { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string StaffName {
            
            get => StaffLName + " " + StaffFName?.ToCharArray()[0] + 
                "." + StaffMName?.ToCharArray()[0];
        }
        public bool OnLeave { get; set; }
        public string StaffFName { get; set; }
        public string StaffLName { get; set; }
        public string StaffMName { get; set; }
        public string Remark { get; set; }
    }
}
