using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hidden_Implement.Models.ViewModels
{
    public class PersonalInfoViewModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
    }
    public class  AddressInfoViewModel : PersonalInfoViewModel{
        public string Street {get; set;}
        public string City {get; set;}
        public string ZipCode {get; set;}
    }
    public class RegistrationSummaryViewModel{
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Street {get; set;}
        public string City {get; set;}
        public string ZipCode {get; set;}
    }
}