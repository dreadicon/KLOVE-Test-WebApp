using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLOVE_webapp_test.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "You must provide an email address")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You must provide a primary phone number")]
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Primary Phone Number")]
        public string PrimaryPhoneNumber { get; set; }
        
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Secondary Phone Number")]
        public string SecondaryPhoneNumber { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
