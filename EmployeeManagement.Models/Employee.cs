using System;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
