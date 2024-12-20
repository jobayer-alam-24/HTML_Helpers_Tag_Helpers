using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Form_Tag_Helpers.Enums;

namespace Form_Tag_Helpers.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter your full name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(500)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Branch is required")]
        public Branch Branch { get; set; }
        public bool TermsAndConditions { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();

        [Required(ErrorMessage = "Please select at least one skill")]
        public List<string> Skills { get; set; } = new List<string>();
    }
}