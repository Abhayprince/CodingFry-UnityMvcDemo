using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityMvcDemoCodingFry.Models
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ICollection<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1, Name= "Employee1", EmpCode="EMP-01",DateOfJoining=new DateTime(2020,01,01)},
                new Employee{Id=2, Name= "Employee2", EmpCode="EMP-02",DateOfJoining=new DateTime(2020,02,01)},
                new Employee{Id=3, Name= "Employee3", EmpCode="EMP-03",DateOfJoining=new DateTime(2020,04,03)}
            };
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return _employees.FirstOrDefault(e => e.Id == employeeId);
        }                
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}