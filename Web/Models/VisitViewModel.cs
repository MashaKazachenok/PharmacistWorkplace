using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class VisitViewModel
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Visit date")]
        [Required(ErrorMessage = "Please enter visit data ")]
        public DateTime VisitData { get; set; }

        [Display(Name = "Order amount")]
        [Required(ErrorMessage = "Please enter order amount")]
        [Range(0, 10000)]
        public double OrderAmount { get; set; }

        [Display(Name = "Order status")]
        [Required(ErrorMessage = "Please enter order status")]
        public string OrderStatus { get; set; }
    }
}