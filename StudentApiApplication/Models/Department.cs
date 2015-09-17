using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApiApplication.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
    }
}