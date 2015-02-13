using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ClientDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double LeftEye { get; set; }
        public double RightEye { get; set; }
        public List<VisitDetailsViewModel> Visits { get; set; }
    }

}