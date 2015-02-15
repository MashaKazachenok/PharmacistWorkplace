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

        [Display(Name = "Имя пользователя")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Display(Name = "Дата рождения")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double LeftEye { get; set; }
        public double RightEye { get; set; }
        public List<VisitDetailsViewModel> Visits { get; set; }
    }

}