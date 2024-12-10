using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DropdownList_Implement.Enums;

namespace DropdownList_Implement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int DepartmentID { get; set; }
    }
}