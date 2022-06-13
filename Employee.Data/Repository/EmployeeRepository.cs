using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
          List<Employee> listofEmployee = new List<Employee>
            {
           new Employee { Id = 1, LastName = "Jackson", FirstName = "Alberta", Department = "Finance", HireDate = Convert.ToDateTime("6/5/2007")},
            new Employee { Id = 2, LastName = "Bennett", FirstName = "Alicia", Department = "Human Resources", HireDate = Convert.ToDateTime("4/15/2001")},
             new Employee { Id = 3, LastName = "Avent", FirstName = "Donna", Department = "Revenue", HireDate = Convert.ToDateTime("4/20/2009")},
              new Employee { Id = 4,LastName = "Holder", FirstName = "Duane", Department = "Human Services", HireDate = Convert.ToDateTime("8/15/2020")}
          };

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns>List of employees</returns>
        public List<Employee> GetAllEmployees()
        {
            //return
            //    listofEmployee.Select(x => new Employee { FirstName = x.FirstName, LastName = x.LastName, Department = x.Department })
            //    .OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            var emplData = from emp in listofEmployee
                           orderby emp.LastName, emp.FirstName
                           select new Employee
                           {
                               LastName = emp.LastName,
                               FirstName = emp.FirstName,
                               Department = emp.Department
                           };

            return emplData.ToList();

        }
        /// <summary>
        /// Get employee based on id
        /// </summary>
        /// <param name="id">Id Input</param>
        /// <returns>Employee object</returns>
        public Employee? GetEmployee(int id)
        {
            return listofEmployee.FirstOrDefault(x => x.Id == id); 
        }

        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employee">employee object</param>
        /// <returns>success/Failure</returns>
        public bool AddEmployee(Employee employee)
        {
            bool EmployeedAdded = true;

            try
            {
                listofEmployee.Add(employee);
            }
            catch (Exception ex)
            {
                EmployeedAdded = false; 
                //Log the exception to eventlog or database
            }

            return EmployeedAdded;
        }

    }
}
