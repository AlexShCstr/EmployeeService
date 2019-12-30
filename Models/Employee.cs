using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string Midllename { get; set; }
        public long DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}