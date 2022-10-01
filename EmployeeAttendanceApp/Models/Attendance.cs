using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceApp.Models
{
    public class Attendance
    {
        public int  EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }

        public string AttendanceDate { get => this.Date.ToString("yyyy-MM-dd"); }
        public string In { get => this.InTime.ToString("hh:mm tt"); }
        public string Out { get => this.OutTime.ToString("hh:mm tt"); }

    }
}
