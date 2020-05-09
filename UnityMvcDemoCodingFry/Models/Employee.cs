using System;

namespace UnityMvcDemoCodingFry.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmpCode { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}