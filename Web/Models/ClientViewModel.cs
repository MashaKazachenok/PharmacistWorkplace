using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ClientViewModel
    {
        [Required(ErrorMessage = "Please enter last name ")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name ")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter phone")]
        [StringLength(25)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter email ")]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter left eye")]
        [Range(-10, 10)]
        public double LeftEye { get; set; }

        [Required(ErrorMessage = "Please enter right eye")]
        [Range(-10,10)]
        public double RightEye { get; set; }
    }
}