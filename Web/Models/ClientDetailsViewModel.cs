using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ClientDetailsViewModel
    {
        public ClientDetailsViewModel()
        {
            Visits = new List<VisitDetailsViewModel>();
        }

        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Left eye")]
        public double LeftEye { get; set; }

         [Display(Name = "Right eye")]
        public double RightEye { get; set; }
        public List<VisitDetailsViewModel> Visits { get; set; }
    }

}