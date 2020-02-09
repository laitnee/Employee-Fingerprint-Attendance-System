using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAttendanceSystem.Models
{
    class ModelContext: DbContext
    {
        public ModelContext() : base("name=cn") { }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<AttendanceRegister> AttendanceRegisterList { get; set;  }
    }
}
