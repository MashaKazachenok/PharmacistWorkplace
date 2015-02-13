using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class VisitViewModel
    {
        public int ClientId { get; set; }
        public DateTime VisitData { get; set; }
        public int OrderAmount { get; set; }
        public string OrderStatus { get; set; }
    }
}