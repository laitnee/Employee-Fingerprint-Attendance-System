using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAttendanceSystem.Models
{
    class Staff
    {
        public int StaffId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public string ImageUrl { get; set; }
        public bool OnLeave { get; set; }
        public byte[] Fingerprint { get; set; }
        [NotMapped]
        public int ObjectState { get; set; }
    }
}
