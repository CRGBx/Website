using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLinux.Models
{
    public class LoginResult
    {
        public string StatusMessage { get; set; }
        public string UserName { get; set; }
    }
    public class Dashboard
    {
        public EmployeeMaster employee { get; set; }
        public int TotalCSPVisitsFY { get; set; }
        public int  CSPVisitsCM { get; set; }
    
    }
    public class MainCategory
    {
        public string CategoryName { get; set; }
        public string CategoryURL { get; set; }
    }
    public class AttendanceOutput {
        public string NetWorkName { get; set; }
        public string RegionCode { get; set; }
        public string EmpName { get; set; }
        public string Attendance { get; set; }
        public string Remarks { get; set; }

        public string ForDate { get; set; }
        public DateTime MarkDate { get; set; }
        public string LatLong { get; set; }

    }
}
