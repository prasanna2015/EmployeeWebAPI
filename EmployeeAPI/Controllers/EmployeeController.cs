using EmployeeAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository employeeRepo = new EmployeeRepository();



        [HttpGet(Name = "GetAllEmployees")]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return employeeRepo.GetAllEmployees();
        }

        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return Ok(employeeRepo.GetEmployee(id));
        }

        [HttpPost(Name = "AddEmployee")]
        public ActionResult<bool> AddEmployee(Employee employee)
        {
            return employeeRepo.AddEmployee(employee);
        }
    }
}

