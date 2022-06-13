using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Data
{

    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        bool AddEmployee(Employee employee);
    }
}
