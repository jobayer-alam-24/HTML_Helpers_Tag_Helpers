using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Editor_Implement.Models
{
    public class Employee
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public decimal Salary {get; set;}
        public bool IsEmployed {get; set;}
        public DateTime DateOfBirth {get; set;}
        [UIHint("Skills")]
        public List<string> Skills {get; set;}
        public Gender Gender {get; set;}
        public IFormFile ProfilePicture {get; set;}
        public Guid UserId {get; set;}
        public TimeSpan WorkingHours {get; set;}
    }
    public enum Gender
    {
        Male, Female, Others
    }
}