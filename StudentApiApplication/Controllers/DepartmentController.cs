using StudentApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApiApplication.Controllers
{
    public class DepartmentController : ApiController
    {
        public static List<Department> departments;
        public DepartmentController()
        {
            departments = new List<Department>() { 
                new Department{ ID = 1, 
                                DepartmentName = "Computer Science",
                                Employees = new List<Employee>{
                                                new Employee{ ID = 1, EmployeeName = "Robert Scott"},
                                                new Employee{ ID = 2, EmployeeName = "Martin Scale"}
                                                            }
                },
                new Department{ ID = 2, 
                                DepartmentName = "Mechanical",
                                Employees = new List<Employee>{
                                                new Employee{ ID = 3, EmployeeName = "Indiana Twain"},
                                                new Employee{ ID = 4, EmployeeName = "Tom Spain"}
                                                            }
                }
            };

        }

        public IEnumerable<Department> Get()
        {
            return departments;
        }
        public Department Get(int id)
        {
            return departments.FirstOrDefault(x => x.ID == id);
        }
       


    }
}
