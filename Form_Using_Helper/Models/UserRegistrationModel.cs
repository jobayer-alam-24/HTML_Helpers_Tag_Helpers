using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Form_Using_Helper.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Address Is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Gender Is Required")]
        public string Gender { get; set; }
        public bool RememberMe { get; set; }

        [Required(ErrorMessage = "Please Select A Course")]
        public string SelectedCourse { get; set; }
        public List<string> Courses { get; set; }

        [Required(ErrorMessage = "Please select one or more skills")]
        public List<string> SelectedSkills { get; set; }
        public List<string> Skills { get; set; }
        public Guid HiddenField { get; set; }
    }
}