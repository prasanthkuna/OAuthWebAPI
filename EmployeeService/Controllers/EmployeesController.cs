using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeEntities db = new EmployeeEntities())
            {
                return db.tblEmployees.Select(x => new Employee
                {
                    FirstName = x.FirstName,
                    Gender = x.Gender,
                    Id = x.ID,
                    HireDate = x.HireDate,
                    JobTitle = x.JobTitle,
                    LastName = x.LastName,
                    Salary = x.Salary,
                    WebSite = x.WebSite
                }).ToList();
            }
        }
    }
}
