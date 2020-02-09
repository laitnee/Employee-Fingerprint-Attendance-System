using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAttendanceSystem.Models
{
    class AttendanceRegister
    {
        public int AttendanceRegisterId { get; set; }
        public DateTime Date { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public string Remark { get; set; }
    }
}
