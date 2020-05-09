using System.Collections.Generic;

namespace UnityMvcDemoCodingFry.Models
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int employeeId);
        void AddEmployee(Employee employee);
    }
}
