using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radiobutton_Implement.Models;

namespace Radiobutton_Implement.Models
{
    public class Company
    {
        public int SelectedDepartment { get; set; }
        public List<Department> ListOfDepartments()
        {
            List<Department> Departments = new List<Department>(){
            new Department {Name = "IT", Id = 1},
            new Department {Name = "HR", Id = 2},
            new Department {Name = "Manager", Id = 3},
            };
            return Departments;
        }
    }
}