using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ClientViewModel
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please enter last name ")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Please enter last name ")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Please enter date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter phone")]
        [StringLength(25)]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Left eye")]
        [Required(ErrorMessage = "Please enter left eye")]
        [Range(-10, 10)]
        public double LeftEye { get; set; }

        [Display(Name = "Right eye")]
        [Required(ErrorMessage = "Please enter right eye")]
        [Range(-10,10)]
        public double RightEye { get; set; }
    }
}