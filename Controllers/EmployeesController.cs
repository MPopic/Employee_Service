using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee_Service.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(Employee_DBEntities entities = new Employee_DBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
