using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Employee
    {

            [Required(ErrorMessage = "Enter  Id")]
            public int EmployeeID { get; set; }
            [Required(ErrorMessage = "Enter First Name")]
            public string FirstName { get; set; }
           
            public string MiddleName { get; set; }
            [Required(ErrorMessage ="Enter Last Name")]
             public string LastName { get; set; }
            public string Gender { get; set; }
            [Required(ErrorMessage = "Enter addess")]
             public string Address { get; set; }
             [Required(ErrorMessage = "Enter City")]
             public string City { get; set; }
            public string State { get; set; }
             [Required(ErrorMessage = "Enter Country")]
             public string Country { get; set; }
             [Required(ErrorMessage = "Enter Mobile number")]
             public string Mobile { get; set; }
        



    }
}